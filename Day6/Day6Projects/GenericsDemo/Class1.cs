﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Helper1
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        public static T add<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            T sum;
            sum = a + b;
            return sum;

        }
    }

        class Helper2<T>
        {
            public static void swap(ref T x, ref T y)
            {
                T temp;
                temp = x;
                x = y;
                y = temp;
            }

            public static T add(T x, T y)
            {
                dynamic a = x;
                dynamic b = y;
                T sum;
                sum = a + b;
                return sum;

            }

        }

}

