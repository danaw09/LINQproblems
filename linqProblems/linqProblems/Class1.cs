﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class Class1
    {
        
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        private object listOfStrings;
        List<string> classGrades = new List<string>() { "90,100,82,89,55", "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        public double classAverageGrade;

        public Class1()
        {

        }

        public void PrintListToBeProcessed(List<string> words)
        {

            var wordsWithTH = words.Any(w => words.Contains(w));

        }

        public void ReturnStringNoDUplicate(List<string> names)
        {

            var wordsNoDuplicate = names.Distinct().ToList();

        }

        public void getClassAverage()
        {
            var temporaryListOfGrades = classGrades.OrderBy(g => g);
        }
        
        public static void AverageClassScore(List<string> classGrades)
        {
            List<int> classGrades = new List<int>();
            double classAverage = 0;
            int numberInClass = 0;
        }

    }
}
