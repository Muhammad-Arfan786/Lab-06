using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> groceries = new List<string>()
 Git-2nd-brance
       git checkout 2nd_branch
nano grocery_list.cs  # Add a different item on line 9
git add grocery_list.cs
git commit -m "Updated line 9 in 2nd_branch"
git push origin 2nd_branch
 {

        git checkout 1st_branch
nano grocery_list.cs  # Add an item on line 9
git add grocery_list.cs
git commit -m "Updated line 9 in 1st_branch"
git push origin 1st_branch
        {
 main
            "Milk",
            "Eggs",
            "Bread",
            "Butter",
            "Apples"
        };

        Console.WriteLine("Grocery List:");
        foreach (var item in groceries)
        {
            Console.WriteLine("- " + item);
        }
    }
}
