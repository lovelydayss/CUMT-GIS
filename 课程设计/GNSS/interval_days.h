#ifndef INTERVAL_DAYS_H
#define INTERVAL_DAYS_H

int yeardays[2] = { 365, 366 };
int monthdays[2][12] = { {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}, {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31} };

int isLearyear(int year)
{
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        return 1;
    else
        return 0;
}
int caldays(int year1, int month1, int day1, int year2, int month2, int day2)
{
    int sumdays = 0;

    if (year1 == year2 && month1 == month2)
    {
        sumdays = day2 - day1;
    }
    else if (year1 == year2)
    {
        sumdays += monthdays[isLearyear(year1)][month1 - 1] - day1;
        for (int i = month1; i < month2 - 1; i++)
            sumdays += monthdays[isLearyear(year1)][i];
        
        sumdays += day2;
    }
    else
    {
        sumdays += monthdays[isLearyear(year1)][month1 - 1] - day1;
        for (int i = month1; i < 12; i++)
            sumdays += monthdays[isLearyear(year1)][i];

        for (int i = year1 + 1; i < year2; i++)
            sumdays += yeardays[isLearyear(i)];

        for (int i = 0; i < month2 - 1; i++)
            sumdays += monthdays[isLearyear(year2)][i];
        sumdays += day2;
    }
    return sumdays;
}

#endif