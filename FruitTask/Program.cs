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


    
Princy Singh
12:17 PM (0 minutes ago)
to me

import { Component } from '@angular/core';

@Component({
  selector: 'app-team-info',
  templateUrl: './team-info.component.html',
  styleUrls: ['./team-info.component.css']
})
export class TeamInfoComponent {
  teams = [
    { tid: 1, tname: 'Team A', temail: 'a@example.com', tslogan: 'Go A!', tlogo: 'logoA.png', IplTitle: 3 },
    { tid: 2, tname: 'Team B', temail: 'b@example.com', tslogan: 'Go B!', tlogo: 'logoB.png', IplTitle: 2 },
    { tid: 3, tname: 'Team C', temail: 'c@example.com', tslogan: 'Go C!', tlogo: 'logoC.png', IplTitle: 1 },
    { tid: 4, tname: 'Team D', temail: 'd@example.com', tslogan: 'Go D!', tlogo: 'logoD.png', IplTitle: 2 },
    { tid: 5, tname: 'Team E', temail: 'e@example.com', tslogan: 'Go E!', tlogo: 'logoE.png', IplTitle: 0 },
  ];
}


<div *ngFor="let team of teams" [ngStyle]="{'background-color': team.IplTitle > 2 ? 'green' : '', 'color': team.IplTitle > 2 ? 'white' : ''}">
  <p>Team ID: {{team.tid}}</p>
  <p>Name: {{team.tname}}</p>
  <p>Email: {{team.temail}}</p>
  <p>Slogan: {{team.tslogan}}</p>
  <p>Logo: <img src="{{team.tlogo}}" alt="{{team.tname}} logo"></p>
  <p>IPL Titles: {{team.IplTitle}}</p>
</div>
}
