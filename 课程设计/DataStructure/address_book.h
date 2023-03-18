#ifndef ADDRESS_BOOK_H
#define ADDRESS_BOOK_H

#include <vector>
#include <string>
#include <iostream>
#include <fstream>
using namespace std;

struct contact
{
    int id;        //序号
    string name;   //姓名
    int relation;  //关系（1为“亲人”，2为“朋友”，3为“同事”）
    string number; //电话号码

    contact() : id(0), name("\0"), relation(0), number("\0") {}
    contact(int i, string na, int r, string nu) : id(i), name(na), relation(r), number(nu) {}
};

class address_book
{
public:
    address_book();
    address_book(vector<contact>& a);                       //利用数组建立通讯簿
    address_book(string& file_name);                        //利用文件数据建立通讯簿

    address_book(address_book& rhs);                        //复制构造函数
    address_book operator=(address_book& rhs);              //赋值运算符重载


    ~address_book() {}
    string Find(string& name);                              //查询联系人
    void addition(int i, string na, int r, string& nu);     //添加联系人
    void change(string& name, int r);                       //修改联系人关系
    void change(string& name, string& nu);                  //修改联系人电话号码
    void remove(string& name);                              //删除联系人
    void print(int r);                                      //按关系输出联系人
    void print();                                           //输出全部联系人

private:
    vector<contact> address;
};

address_book::address_book() {}
address_book::address_book(vector<contact>& a) : address(a.size())
{
    for (int i = 0; i < a.size(); i++)
    {
        address[i].id = a[i].id;
        address[i].relation = a[i].relation;
        address[i].name = a[i].name;
        address[i].number = a[i].number;
    }
}
address_book::address_book(string& file_name)
{
    int address_nums;
    ifstream in_file(file_name);
    if (!in_file)
    {
        cout << "打开文件失败" << endl;
        return;
    }

    in_file >> address_nums;
    if (!address.empty())
    {
        address.clear();
    }
    for (int i = 0; i < address_nums; i++)
    {
        int id, relation;
        string name, number;
        in_file >> id >> name >> relation >> number;
        contact m(id, name, relation, number);
        address.push_back(m);
    }
}

address_book::address_book(address_book& rhs)
{
    if (rhs.address.empty())
    {
        address.clear();
    }
    else
    {
        address = rhs.address;
    }
}
address_book address_book::operator=(address_book& rhs)
{
    if (rhs.address.empty())
    {
        address.clear();
        return *this;
    }
    else
    {
        address = rhs.address;
        return *this;
    }
}


string address_book::Find(string& name)
{
    for (int i = 0; i < address.size(); i++)
    {
        if (address[i].name == name)
        {
            return address[i].number;
        }
    }
    cout << "未找到" << endl;
    return string(0);
}
void address_book::addition(int i, string na, int r, string& nu)
{
    contact m(i, na, r, nu);
    address.push_back(m);
}
void address_book::change(string& name, int r)
{
    for (int i = 0; i < address.size(); i++)
    {
        if (address[i].name == name)
        {
                address[i].relation = r;
                return;
        }
    }
    cout << "无匹配联系人" << endl;
}
void address_book::change(string& name, string& nu)
{
    for (int i = 0; i < address.size(); i++)
    {
        if (address[i].name == name)
        {
            address[i].number = nu;
            return;
        }
    }
    cout << "无匹配联系人" << endl;
}
void address_book::remove(string& name)
{
    for (int i = 0; i < address.size(); i++)
    {
        if (address[i].name == name)
        {
            address.erase(address.begin() + i);
            return;
        }
    }
    cout << "无匹配联系人" << endl;
}
void address_book::print(int r)
{
    string relation;
    switch (r)
    {
    case 1:
        relation = "亲人";
        break;
    case 2:
        relation = "朋友";
        break;
    case 3:
        relation = "同事";
        break;
    default:
        cout << "错误输入" << endl;
        return;
    }

    for (int i = 0; i < address.size(); i++)
    {
        if (address[i].relation == r)
        {
            cout << address[i].id << " " << address[i].name << " " << relation << " " << address[i].number << endl;
        }
    }
}
void address_book::print()
{
    for (int i = 0; i < address.size(); i++)
    {
        cout << address[i].id << " " << address[i].name << " " << address[i].relation << " " << address[i].number << endl;
    }
}

#endif