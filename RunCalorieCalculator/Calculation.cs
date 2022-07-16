using RunCalorieCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunCalorieCalculator
{

    public enum Gender
    {
        Male,
        Female
    }

    public static class Calculation
    {
        public static Dictionary<double, double> MetVal = new Dictionary<double, double>()
        {
            {6,6},
            {7,6.9},
            {8,8.3},
            {9,9.4},
            {10,10},
            {11,10.75},
            {12,11.7},
            {13,11.9},
            {14,12.4},
            {15,13.3},
            {16,14.4},
            {17,15.3},
            {18,16.6},
            {19,18.4},
            {20,19.35},
            {21,20},
            {22,22.0},
            {23,23.0}
        };

        public static double CalculateBMR(Gender gender, int age, double weight, double height)
        {
            double bmr = 0;

            switch (gender)
            {
                case Gender.Male:
                    bmr = (float)(10 * weight + 6.25 * height - 5 * age + 5);
                    break;
                case Gender.Female:
                    bmr = (float)(10 * weight + 6.25 * height - 5 * age - 161);
                    break;
                default:
                    break;
            }

            return bmr;
        }

        public static double CalculateCalorie(Gender gender, int age, double weight, double height, int speed, int duration)
        {
            var bmr = Calculation.CalculateBMR(gender, age, weight, height);

            //Calorie(Kcal) ＝ BMR x Mets / 24 x hour

            var met = MetVal[speed];


            var calorie = bmr * (met * (duration / 60.0)) / 24.0;

            return calorie;
        }
    }
}
