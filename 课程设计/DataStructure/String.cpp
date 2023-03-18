#include"String.h"
using namespace std;

int main()
{
	const char* p = "hello ";
	const char* q = "Stephen Curry of Golden State Warriors ";
	String test;
	String test1(p);
	String test2(q);

	cout << "字符串1为： " << test1 << "其长度为:" << test1.Length() << endl;
	cout << "字符串2为： " << test2 << "其长度为:" << test2.Length() << endl << endl;

	cout << "字符串1中各字符出现频率为：" << endl;
	test1.frequency();
	cout << "字符串2中各字符出现频率为：" << endl;
	test2.frequency();

	cout << "将字符串2连接至字符串1上" << endl;
	test1 += test2;

	cout << "连接后字符串1为： " << test1 << "其长度为:" << test1.Length() << endl;

	cout << "\n重载后[]运算符测试" << endl << endl;

	cout << "字符串1中第4个元素为： " << test1[3] << endl;
	cout << "字符串2中第5个元素为： " << test2[4] << endl;

	cout << "\n重载后赋值运算符测试" << endl << endl;

	test = test1;
	cout << test << endl;

	cout << "\n重载后各关系运算符测试" << endl << endl;

	cout << (test1 == test2) << " " << (test1 != test2)<<" "<< !test1 << endl;

	cout << "\n字符串匹配测试" << endl << endl;

	const char* r = "Curry";
	String find(r);
	cout << test1.Find(find, 2) << endl;

	return 0;
}