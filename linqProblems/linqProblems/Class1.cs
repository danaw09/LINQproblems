using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class Class1
    {
        
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        private object listOfStrings;

        public List<string> addStringToList(List <string> list)
        {

        }
       

        public List<string> RemoveDuplicatesFromStringList(List<string> list)
        {
            var listOfStringsWithOutDuplicates = listOfStrings.Distinct().ToList();
            string delimiter = ", ";
            Console.WriteLine("Here is the new list: " + listOfStringsWithOutDuplicates.Aggregate((i, j) => i + delimiter + j) + ".\n");
            return listOfStringsWithOutDuplicates;
        }

    }
}
