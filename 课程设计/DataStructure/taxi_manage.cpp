#include "taxi_manage.h"

int main()
{
	int num;
	map<string, list<taxi>> ta;

	cout << "请开始出租车租用系统的初始化" << endl;
	cout << "请输入出租车型号数 ";
	cin >> num;
	for (int i = 0;i < num;i++)
	{
		int nums,costs,forfeits;
		string s;
		cout << "请输入出租车类型名，数量，日租金和损坏罚金 ";
		cin >> s >> nums >> costs >> forfeits;

		list<taxi> l_list;
		for (int i = 0;i < nums;i++)
		{
			taxi t;
			t.id = i;
			t.type = s;
			t.status = 1;
			t.cost = costs;
			t.forfeit = forfeits;

			l_list.push_back(t);
		}
		ta[s] = l_list;
	}
	taxi_manage t_manage(ta);

	cout << "\n请选择所需要操作(输入 t 结束)： " << endl;
	cout << "租车请输 1" << endl;
	cout << "还车请输 2" << endl;
	cout << "查询请输 3" << endl;
	cout << "维修请输 4" << endl<<endl;

	int k;
	while (cin >> k)
	{
		if (k == 1)
		{
			t_manage.print_type();
			cout << "\n请输入您的姓名及所需车辆类型" << endl;
			string n, t;
			vector<int> d(3);
			cin >> n >> t;
			cout << "请输入今日日期(年，月，日)" << endl;
			cin >> d[0] >> d[1] >> d[2];

			t_manage.rent_car(n, t, d);
		}
		else if (k == 2)
		{
			cout << "请输入所租汽车序列号及类型" << endl;
			int i;
			bool s;
			string t;
			cin >> i >> t;
			cout << "出租车是否损坏（损坏请输0，未损坏则输1）" << endl;
			cin >> s;
			t_manage.return_car(i, t, s);
		}
		else if (k == 3)
		{
			t_manage.enquiries();
		}
		else if (k == 4)
		{
			t_manage.service();
		}
		else
		{
			cout << "错误输入,请重试" << endl;
		}

		cout << "\n请选择下一个操作(输入 t 结束) " << endl;
	}
}