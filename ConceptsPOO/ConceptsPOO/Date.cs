using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            _day = CheckDay(day, month, year);
            _month = CheckMoth(month);
            _year = year;
        }

        private int CheckDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Invalid day, please check");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

            //if((year % 4) == 0)
            //{
            //    if ((year % 100) == 0)
            //    {
            //        if ((year % 400) == 0)
            //        {
            //            return true;
            //        }
            //    }
            //}
            //else
            //{
            //    return false;
            //}

            throw new NotImplementedException();
        }

        private int CheckMoth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MontException($"Ivalid month");
        }

        public override string ToString()
        {
            //return _day + "/" + _month + "/" + _year; 
            return $"{_day:00}/{_month:00}/{_year}";
        }
    }
}
