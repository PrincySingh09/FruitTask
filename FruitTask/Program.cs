using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruitList = new ArrayList();
            fruitList.Add("apple");
            fruitList.Add("banana");
            fruitList.Add("cherry");
            fruitList.Add("date");
            fruitList.Add("elderberry");
            Console.WriteLine("Total elements in ArrayList:" + fruitList.Count);
            PrintElements(fruitList);
            Console.WriteLine("\nArray list contain date:" + fruitList.Contains("date"));
            fruitList.Insert(1, "fig");
            PrintElements(fruitList);
            Console.WriteLine("\nAfter inserting 'fig' at the second position:");
            PrintElements(fruitList);
            fruitList.Remove("banana");
            Console.WriteLine("\nAfter removing banana:");
            PrintElements(fruitList);
            Console.WriteLine("\nSearch for apple:" + (fruitList.IndexOf("apple") != -1 ? "Found" : "Not Found"));
            void PrintElements(ArrayList list)
            {
                Console.WriteLine("\nElements in ArrayList:");
                foreach (string item in list)
                {
                    Console.WriteLine(item);

                }
                Console.ReadKey();
            }
        }
    }
}

<!DOCTYPE html>
<html>
<head>
    <title>Eligibility Checker</title>
    <script type="text/javascript">
        function checkEligibility() {
            var age = document.getElementById('age').value;
            var eligibilityStatus = 'Not eligible for voting';
            if (age >= 18) {
                eligibilityStatus = 'Eligible for voting';
            }
            document.getElementById('eligibilityStatus').innerText = eligibilityStatus;
        }
    </script>
</head>
<body>
    <h1>Eligibility Checker</h1>
    <label for="age">Enter your age:</label><br>
    <input type="text" id="age" name="age"><br>
    <button onclick="checkEligibility()">Check Eligibility</button>
    <p id="eligibilityStatus"></p>
</body>
</html>
