 #include "Tball.h"

int main()
{
    Tball test1, test2;
    
    cout << " >> << 运算符重载测试 " << endl;
    
    cin >> test1;
    cout << test1;

    Tball test3(1, 2, 3, 4);

    cout << "\n = 运算符重载测试" << endl;

    cout << test3;
    test2 = test3;
    cout << test2;

    cout << "\n 体积，表面积，输出函数调试" << endl;

    test3.print();
    cout << "球体体积为： " << test3.volume() << endl;
    cout << "球体表面积为： " << test3.area() << endl;

    return 0;
}