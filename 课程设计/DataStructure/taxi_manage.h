#ifndef TAXI_MANAGE_H
#define TAXI_MANAGE_H

#include <list>
#include <vector>
#include <string>
#include <map>
#include <iostream>
#include "interval_days.h"                           //计算两天之间间隔
using namespace std;


struct taxi
{
    int id;           //出租车编号
    string type;      //出租车型号
    bool status;      //出租车状态 (1,0分别代表出租车好与坏)
    string name;      //顾客姓名
    vector<int> date; //租用日期 (数组前三个元素分别表示年，月，日)
    int cost;         //日租金额
    int forfeit;      //损坏罚金

};

class taxi_manage
{
public:
    taxi_manage(){}
    taxi_manage(map<string, list<taxi>>& l_list);

    taxi_manage(taxi_manage& rhs);                    //复制构造函数
    taxi_manage operator=(taxi_manage& rhs);          //赋值运算符重载

    void rent_car(string n, string t, vector<int> d); //租车
    void return_car(int i, string t, bool s);         //还车
    void enquiries();                                 //查询出租车信息
    void service();                                   //出租车维修
    void print_type();                                //输出系统中所包含的出租车类型

private:
    map<string, list<taxi>> lend_list;                //使用散列将不同类型出租车储存在不同链表中从而实现快速查取
    list<taxi> rented_list;
};

taxi_manage::taxi_manage(map<string, list<taxi>>& l_list)
{
    lend_list = l_list;
}

taxi_manage::taxi_manage(taxi_manage& rhs)
{
    lend_list.clear();
    rented_list.clear();

    lend_list = rhs.lend_list;
    rented_list = rhs.rented_list;
}
taxi_manage taxi_manage::operator=(taxi_manage& rhs)
{
    lend_list.clear();
    rented_list.clear();

    lend_list = rhs.lend_list;
    rented_list = rhs.rented_list;
    return *this;
}

void taxi_manage::rent_car(string n, string t, vector<int> d)
{
    if (!lend_list.count(t))
    {
        cout << "无指定出租车类型，请重新输入" << endl;
        return;
    }

    taxi r_taxi;
    r_taxi.date = d;
    r_taxi.name = n;
    r_taxi.type = t;
    r_taxi.status = 1;

    for (auto m = lend_list[t].begin(); m != lend_list[t].end(); m++)
    {
        if (m->status)
        {
            r_taxi.id = m->id;
            r_taxi.cost = m->cost;
            r_taxi.forfeit = m->forfeit;
            lend_list[t].erase(m);
            break;
        }
    }
    rented_list.push_back(r_taxi);

    cout << "您所租车辆的序号为： " << r_taxi.id << endl;
}
void taxi_manage::return_car(int i, string t, bool s)
{
    taxi l_taxi;
    vector<int> old_date;
    int year, month, day;

    for (auto m = rented_list.begin(); m != rented_list.end(); m++)
    {
        if (m->id == i && m->type == t)
        {
            l_taxi.id = m->id;
            l_taxi.cost = m->cost;
            l_taxi.type = t;
            l_taxi.forfeit = m->forfeit;
            l_taxi.status = s;
            old_date = m->date;
            rented_list.erase(m);
            lend_list[t].push_back(l_taxi);
            break;
        }
    }

    if (l_taxi.cost == 0)
        cout << "无此租用信息，请检查输入信息是否有误" << endl;
    
    cout << "请输入今日日期(年，月，日) " << endl;
    cin >> year >> month >> day;
    int days = caldays(old_date[0], old_date[1], old_date[2], year, month, day);
    cout << "租金费用为: " << days * l_taxi.cost << endl;
    if (s == 0)
    {
        cout << "出租车已损坏，所需赔偿金额为： " << l_taxi.forfeit << endl;
        cout << "总计：" << (days * l_taxi.cost + l_taxi.forfeit) << " 元" << endl;
    }
    else
    {
        cout << "总计：" << days * l_taxi.cost << " 元" << endl;
    }
}
void taxi_manage::enquiries()
{ 
    for (auto m = lend_list.begin(); m != lend_list.end(); m++)
    {
        int count = 0;
        int f_count = 0;
        int t_count = 0;
        for (auto n = m->second.begin(); n != m->second.end(); n++)
        {
            if (n->status == 0)
                f_count++;
            else
                t_count++;
        }
        cout << m->first << " 类型出租车剩余 " << f_count + t_count << " 辆" << endl;
        cout << "其中损坏 " << f_count << " 辆 , "<< "完好 " << t_count << " 辆" << endl;
    }

    cout << "以下为已出租汽车名单: " << endl;
    for (auto m = rented_list.begin(); m != rented_list.end(); m++)
    {
        cout << "出租车号: " << m->id << " 出租车类型: " << m->type << " 租用者姓名: " << m->name
            << " 租用日期： " << m->date[0] << " " << m->date[1] << " " << m->date[2] << endl;
    }
}
void taxi_manage::service()
{
    for (auto m = lend_list.begin(); m != lend_list.end(); m++)
    {
        int count = 0;
        for (auto n = m->second.begin(); n != m->second.end(); n++)
        {
            if (n->status == 0)
            {
                n->status = 1;
                count++;
            }
        }
        cout << m->first << " 类型出租车损坏" << count << "辆" << endl;
    }
    cout << "所有损坏出租车已维修完毕" << endl;
}
void taxi_manage::print_type()
{
    cout << "以下为可租用出租车清单" << endl;
    for (auto m = lend_list.begin(); m != lend_list.end(); m++)
    {
        int t_count = 0;
        for (auto n = m->second.begin(); n != m->second.end(); n++)
        {
            if (n->status == 1)
                t_count++;
        }
        cout << m->first << " 型出租车  " << t_count << " 辆"<<endl;
    }
}

#endif