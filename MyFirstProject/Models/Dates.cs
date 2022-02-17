using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public static class Dates
    {
        public static DateTime MinDate { get; } = new DateTime(2021, 01, 01);

        public static DateTime MaxDate { get; } = new DateTime(2025, 12, 31);

        public static DateTime CurrentDate { get; } = DateTime.Now;
    }
}
