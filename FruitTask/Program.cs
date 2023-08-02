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
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .header, .footer {
            background: #f8f9fa;
            padding: 10px;
            width: 100%;
            text-align: center;
        }

        .main {
            display: flex;
            width: 100%;
        }

        .main .news {
            flex-grow: 1;
            padding: 20px;
        }

        .main .slideshow {
            width: 200px;
            height: 300px;
        }

        .slideshow img {
            width: 100%;
            height: auto;
        }
    </style>
</head>
<body>
    <div class="header">
        <h1>Website Name</h1>
        <a href="sports.html">Sports</a>
        <a href="movies.html">Movies</a>
        <a href="politics.html">Politics</a>
        <a href="gk.html">GK</a>
    </div>

    <div class="main">
        <div class="slideshow" id="slideshowLeft">
            <img src="your_image_source_here" alt="Slide 1">
            <!-- Add more images as needed -->
        </div>

        <div class="news">
            <!-- Add news here -->
        </div>

        <div class="slideshow" id="slideshowRight">
            <img src="your_image_source_here" alt="Slide 1">
            <!-- Add more images as needed -->
        </div>
    </div>

    <div class="footer">
        All Rights Reserved & copyright info
    </div>

    <script>
        // JavaScript for slideshow
        var slideIndex = 0;

        function showSlides(slideshowId) {
            var i;
            var slides = document.getElementById(slideshowId).getElementsByTagName("img");
            for (i = 0; i < slides.length; i++) {
                slides[i].style.display = "none";
            }
            slideIndex++;
            if (slideIndex > slides.length) {slideIndex = 1}
            slides[slideIndex-1].style.display = "block";
            setTimeout(showSlides, 2000, slideshowId);
        }

        showSlides("slideshowLeft");
        showSlides("slideshowRight");
    </script>
</body>
</html>

