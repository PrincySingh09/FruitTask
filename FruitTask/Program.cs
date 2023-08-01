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
<style>
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f1f1f1;
}
.container {
    width: 300px;
    padding: 16px;
    background-color: white;
    margin: 0 auto;
    margin-top: 100px;
    border: 1px solid #f1f1f1;
    border-radius: 4px;
}
input[type=text], input[type=password], input[type=email], select, input[type=datetime-local] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
}
input[type=submit] {
    width: 100%;
    background-color: #4CAF50;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}
input[type=submit]:hover {
    background-color: #45a049;
}
</style>
</head>
<body>

<div class="container">
  <form action="your-target-url" method="get">
    <label for="uname">Username:</label><br>
    <input type="text" id="uname" name="uname" required><br>
    <label for="pwd">Password:</label><br>
    <input type="password" id="pwd" name="pwd" required><br>
    <label for="email">Email:</label><br>
    <input type="email" id="email" name="email" required><br>
    <label for="utype">User Type:</label><br>
    <select id="utype" name="utype">
      <option value="gold">Gold</option>
      <option value="silver">Silver</option>
      <option value="bronze">Bronze</option>
    </select><br>
    <label for="ucity">User City:</label><br>
    <select id="ucity" name="ucity">
      <!-- Add your options here -->
      <option value="city1">City1</option>
      <option value="city2">City2</option>
    </select><br>
    <label for="eos">End of Subscription:</label><br>
    <input type="datetime-local" id="eos" name="eos"><br>
    <input type="submit" value="Submit">
  </form>
</div>

</body>
</html>
