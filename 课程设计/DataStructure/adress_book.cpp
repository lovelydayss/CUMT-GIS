
#include "address_book.h"

int main()
{
	int m,n;
	address_book a_book;

	int id, relation;
	string name, number;

	cout << "请建立通讯簿" << endl << endl;
	cout << "建立空通讯簿请输入 0 " << endl;
	cout << "由文件建立通讯簿请输 1 " << endl;
	cout << "由输入数据建立通讯簿请输 2 " << endl;

	cin >> m;

	if (m==0){}
	else if(m==1)
	{
		string filename;
		cout << "请输入文件地址" << endl;
		cout << "文件格式：第一行为数据个数，接下来每行为一个数据，数据各项按序号，姓名，关系，号码依次排列，以空格分隔" << endl;
		cin >> filename;
		address_book a_b(filename);
		a_book = a_b;
	}
	else if(m==2)
	{
		int count;
		vector<contact> s;
		cout << "请输入通讯簿数据个数" << endl;
		cin >> count;
		cout << "请依次输入序号，姓名，关系（ 1为“亲人”，2为“朋友”，3为“同事” ），电话号码" << endl;
		for (int i = 0;i < count;i++)
		{
			cout << "请输入第 " << i + 1 << " 个联系人" << endl;
			cin >> id >> name >> relation >> number;
			contact c(id, name, relation, number);
			s.push_back(c);
		}
		address_book a_b(s);
		a_book = a_b;
	}
	else
	{
		cout << "错误输入，程序中止" << endl;
		return 0;
	}

	cout << "请选择所需要的通讯簿操作 (输入 t 退出)" << endl;
	cout << "可选择操作：" << endl << endl;
	
	cout << "添加新联系人信息请输 0 " << endl;
	cout << "查询指定联系人号码请输 1 " << endl;
	cout << "修改指定联系人信息请输 2 " << endl;
	cout << "删除指定联系人信息请输 3" << endl;
	cout << "输出同一关系联系人信息请输 4 " << endl;
	cout << "输出所有联系人信息请输 5 " << endl;

	while (cin >> n)
	{
		if (n == 0)
		{
			cout << "请依次输入新联系人序号，姓名，关系（ 1为“亲人”，2为“朋友”，3为“同事” ），电话号码" << endl;
			cin >> id >> name >> relation >> number;
			a_book.addition(id, name, relation, number);
		}
		else if (n == 1)
		{
			cout << "请输入所需查询联系人姓名" << endl;
			cin >> name;
			cout << a_book.Find(name) << endl;
		}
		else if (n == 2)
		{
			int k;
			cout << "请输入所需修改的数据项（ 号码项请输 0 ，关系项请输 1 ，两项均修改请输 2）" << endl;
			cin >> k;
			if (k==0)
			{
				cout << "请输入指定联系人姓名和修改后号码" << endl;
				cin >> name >> number;
				a_book.change(name, number);
			}
			else if(k==1)
			{
				cout << "请输入指定联系人姓名和修改后关系" << endl;
				cin >> name >> relation;
				a_book.change(name, relation);
			}
			else if (k == 3)
			{
				cout << "请输入指定联系人姓名，电话号码和修改后关系" << endl;
				cin >> name >>number>> relation;
				a_book.change(name, number);
				a_book.change(name, relation);
			}
			else
			{
				cout << "错误输入，请重试" << endl;
				continue;
			}
		}
		else if (n == 3)
		{
			cout << "请输入所需删除联系人姓名" << endl;
			cin >> name;
			a_book.remove(name);
		}
		else if (n == 4)
		{
			cout << "请输入所需输出关系项" << endl;
			cin >> relation;
			a_book.print(relation);
		}
		else if (n == 5)
		{
			a_book.print();
		}
		else
		{
			cout << "错误输入，请重试"<<endl;
			continue;
		}
		
		cout << "请选择所需要的通讯簿操作 (输入 t 退出)" << endl;

	}
	return 0;
}
