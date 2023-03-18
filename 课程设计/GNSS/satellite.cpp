#include<regex>
#include<fstream>
#include<iostream>
#include<iomanip>

#include<vector>
#include<string>
#include<cmath>

using namespace std;

const double U = 3.986004418e+14;		// 地球引力常数
const double E = 7.292115e-5;			// 地球平均角速度
const double C = 299792458;				// 光速
const double PI = 3.14159265;			// 圆周率

// 时间结构
struct Time
{
	int year;
	int month;
	int day;
	int hour;
	int min;
	double second;

	Time(int y, int m, int d, int h, int min, int s):year(y),month(m),day(d),hour(h),min(min),second(s){}
};

// 每一年的天数
int year_days(int year)
{
	int count = 0;
	if (year == 1980)	count = 360;													// 若是 1980 年的话，按照算法 360 天
	else if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))	count = 366;	// 若是闰年，则 1 年有 366 天
	else	count = 365;																// 若平闰年，则 1 年有 365 天
	return count;
}

// 每个月的天数
int month_days(int year, int month)
{
	int count = 0;																			// 存储每个月的天数
	if (year == 1980 && month == 1) count = 25;												// 根据算法，1980 年 1 月算作 25 天
	else if (month == 4 || month == 6 || month == 9 || month == 11) count = 30;				// 四六九冬 30 整
	else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) count = 31;
	else
	{
		if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))	count = 29;			// 若是闰年，则 2 月有 29 天
		else count = 28;
	}
	return count;
}

// GPS周内秒
long double get_seconds(Time& t)
{											
	int days = t.day;
	for (int i = 1980; i < t.year; i++)	days += year_days(i);							// 计算年天数
	for (int i = 1; i < t.month; i++)	days += month_days(t.year, i);					// 计算月天数
	return (days % 7) * 86400 + (t.hour * 3600) + (t.min * 60) + t.second;
}

// 规化时间
long double t_k(Time& t, long double toe)
{
	long double ts = get_seconds(t) - toe;
	if (ts > 302400)
	{
		ts -= 604800;
	}
	if (ts < -302400)
	{
		ts += 604800;
	}
	return ts;
}

// 平近点角
long double m_k(long double m0, long double n, long double tk)
{
	long double mk = m0 + (n * tk);
	while (mk < 0)
	{
		mk += 2 * PI;
	}
	while (mk > 0)
	{
		mk -= 2 * PI;
	}
	return mk;
}

// 偏近点角
long double e_k(long double mk, long double e)
{
	long double ek = mk;									//	偏近点角	ek
	long double temp = 0;
	while (fabs(ek - temp) > 0.10e-12)
	{
		temp = ek;
		ek = mk + (e * sin(temp));
	}
	return ek;
}

// 真近点角
long double Nu_k(long double ek, long double e)
{
	long double cos_Nuk = (cos(ek) - e) / (1 - e * cos(ek));
	long double sin_Nuk = (sqrt(1 - pow(e, 2)) * sin(ek)) / (1 - e * cos(ek));
	long double Nuk;
	if (cos_Nuk == 0)
	{
		Nuk = sin_Nuk > 0 ? PI / 2 : -PI / 2;
	}
	else
	{
		Nuk = atan(sin_Nuk / cos_Nuk);
	}

	if (cos_Nuk < 0)
	{
		Nuk += sin_Nuk > 0 ? PI : -PI;
	}
	return Nuk;
}

// 数据输入
void data_input(string ifile, vector<vector<long double>>& vt)
{
	ifstream infile;
	infile.open(ifile);
	if (!infile.is_open())
	{
		cout << "File " << ifile << " opening failed!! " << endl;
	}

	string s;
	int i = 0;
	smatch data_match;
	vector<long double> vi;

	regex segment("\^([ ]|\\d){20}[.]\\d");
	regex segment_time("(\\d{1,2}[.]\\d{1,2})|(\\d{1,2})");
	regex pattern("[+-| ]\\d[.]\\d{12}[D][+-]\\d{2}");

	while (getline(infile, s))
	{
		//if (vt.size() > 100) { break; }
		if (regex_search(s, data_match, segment))
		{
			string s_time = data_match.str();
			vt.push_back(vi);
			vi.clear();

			while (regex_search(s_time, data_match, segment_time))		//匹配卫星序号及时间信息
			{
				vi.push_back(stold(data_match.str()));
				//cout << data_match.str() << " ";
				s_time = data_match.suffix();
			}

			while (regex_search(s, data_match, pattern))				//匹配其他数据信息
			{
				vi.push_back(stold(data_match.str().substr(0, 14)) * pow(10, stold(data_match.str().substr(16, 18))));
				//cout << data_match.str() << " ";
				s = data_match.suffix();
			}

		}
		while (regex_search(s, data_match, pattern))					//匹配其他数据信息
		{
			vi.push_back(stold(data_match.str().substr(0, 14)) * pow(10, stold(data_match.str().substr(16, 18))));
			//cout << data_match.str() << " ";
			s = data_match.suffix();
		}

	}

	vt.push_back(vi);
	infile.close();
}

// 数据计算及输出
void data_process(vector<long double> &data, ofstream& os)
{
	// 年，月，日，时，分，秒

	int satellites_num = data[0];
	int year = data[1] + 2000;
	int month = data[2];
	int day=data[3];
	int hour = data[4];
	int min = data[5];
	double second = data[6];


	long double af0 = data[7];							// 卫星钟差
	long double af1 = data[8];							// 卫星钟速
	long double af2 = data[9];                          // 卫星钟速变率

	long double IODE = data[10];						// 数据龄期
	long double Crs = data[11];							// 轨道半径正弦调和项改正的振幅
	long double a_poor = data[12];						// 平均角速度之差
	long double m0 = data[13];							// 平近点角

	long double Cuc = data[14];							// 纬度幅角的余弦调和项改正的振幅
	long double e = data[15];							// 轨道偏心率
	long double Cus = data[16];							// 纬度幅角的余弦调和项改正的振幅
	long double sqrtA = data[17];						// 轨道长半径的平方根

	long double toe = data[18];							// 轨道参数的参考时间
	long double Cic = data[19];							// 轨道倾角的余弦调和项改正的振幅
	long double Ra0 = data[20];							// 升交点赤经
	long double Cis = data[21];							// 轨道倾角的正弦调和项改正的振幅

	long double i0 = data[22];							// 轨道倾角
	long double Crc = data[23];							// 轨道半径的余弦调和项改正的振幅
	long double w = data[24];							// 近地点角距
	long double Ra = data[25];							// 升焦点赤经变化率

	long double idot = data[26];						// 倾角变化率
	long double L2 = data[27];							// L2上的码
	long double g_week = data[28];						// GPS 周数
	long double L2P = data[29];							// L2上的P码

	long double acc = data[30];							// 卫星精度
	long double state = data[31];						// 健康状态
	long double Tgd = data[32];							// 电离层时延迟差
	long double IODC = data[33];						// 星钟的数据龄期

	long double s_time = data[34];						// 电文发送时刻
	long double f_val = data[35];						// 拟合区间

	Time t(year, month, day, hour, min, second);
	//cout <<year_days(year)<<" "<<month_days(year,month)<<" "<<get_seconds(t) << " " << toe << endl;

	//计算

	long double n = (sqrt(U / pow(sqrtA, 3)) + a_poor) * pow(10, -6);		//	校正后的平均角速度 n
	long double tk = t_k(t, toe);											//	规化时间 tk
	long double mk = m_k(m0, n, tk);										//	平近点角 mk
	long double ek = e_k(mk, e);											//	偏近点角	ek
	long double Nuk = Nu_k(ek, e);											//  真近点角 Nuk
	long double Phik = Nuk + w;												//  升交点角距 Phik
	long double r0 = pow(sqrtA, 2) * (1 - e * cos(ek));						//  r0
	long double uk = (Cuc * cos(2 * Phik)) + (Cus * sin(2 * Phik)) + Phik;						//  摄动校正后升交点角距 u_k
	long double rk = (Crc * cos(2 * Phik)) + (Crs * sin(2 * Phik)) + r0;						//  摄动后卫星矢径长度 r_k
	long double ik = (Cic * cos(2 * Phik)) + (Cis * sin(2 * Phik)) + i0 + idot * tk;			//  摄动后轨道倾角 i_k

	long double xk = rk * cos(uk);																//  平面直角坐标系中的坐标
	long double yk = rk * sin(uk);
	long double zk = 0;
	long double Rak = Ra0 + (Ra - E) * tk - E * toe;											//  升交点赤经 Rak

	long double Xk = xk * cos(Rak) - yk * cos(ik) * sin(Rak);									//  WGS84坐标系下卫星坐标
	long double Yk = xk * sin(Rak) + yk * cos(ik) * cos(Rak);
	long double Zk = yk * sin(ik);

	long double F = -2 * sqrt(U) / pow(C, 2);													//  常数 F
	long double dtr = F * e * sqrtA * sin(ek);													//  相对论修正项 dtr
	long double Tk = af0 + af1 * tk + af2 * pow(tk, 2) + dtr;									//  卫星钟差 Tk
	long double dts = af1 + 2 * af2 * tk + F * e * sqrtA * cos(ek);								//  卫星钟漂 dts

	//输出

	os << fixed << setprecision(8) << "PG" << satellites_num << " " << year << "/" << month << "/" << day << " " << hour << ":" << min << ":" << second
		<< " " << Xk / 1000 << " " << Yk / 1000 << " " << Zk / 1000 << " " << Tk * pow(10, 6) << endl;
	
}

// 根据广播星历计算卫星位置，钟差及钟漂
void satellite(string ifile, string ofile)
{
	vector<vector<long  double>> vt;

	data_input(ifile, vt);

	ofstream outfile;
	outfile.open(ofile);
	if (!outfile.is_open())
	{
		cout << "File " << ofile << " opening failed!! " << endl;
	}

	outfile << "nums  year/month/day  hour:min:second  X  Y  Z  T" << endl;		//

	for (int i = 1;i < vt.size();i++)
	{
		data_process(vt[i], outfile);
	}

	outfile.close();
}


int main()
{
	//string ifile = "C:\\Users\\Ok\\Desktop\\brdc2850.20n";
	//string ofile = "C:\\Users\\Ok\\Desktop\\GPS5.txt";

	for (int i = 1;i < 12;i++)
	{
		string ifile = "C:\\Users\\Ok\\Desktop\\课程文件\\GNSS\\广播星历计算\\brdc\\brdc" + to_string(2800 + 10 * (i + 3)) + ".20n";
		string ofile = "C:\\Users\\Ok\\Desktop\\课程文件\\GNSS\\广播星历计算\\position\\GPS" + to_string(i)+".txt";
		satellite(ifile, ofile);
		cout << "file GPS" << i << " running successful!!" << endl;
	}
	//satellite(ifile, ofile);

	return 0;
}