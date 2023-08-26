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


        <form #form="ngForm" autocomplete="off" (submit)="onSubmit(form)">

    <input type="hidden" name="Id" [value]="objservice.ppData.Id">

    <div class="form-group">

    <div class="input-group">

    <div class="input-group-prepend">    

     <div class="input-group-text bg-white">

     <i class="fa fa-user-circle-o" aria-hidden="true" [class.green-icon]="HolderName.valid"

      [class.red-icon]="HolderName.invalid && HolderName.touched"></i>

     <input name="HolderName" #HolderName="ngModel"   [(ngModel)]="objservice.ppData.HolderName"

     placeholder="PassPort Holder Name" class="form-control" required>    

    </div></div>  </div>   </div>
          <div class="form-group">

        <div class="input-group">

        <div class="input-group-prepend">    

         <div class="input-group-text bg-white">

         <i class="fa fa-diamond" aria-hidden="true" [class.green-icon]="PassportNumber.valid" [class.red-icon]="PassportNumber.invalid && PassportNumber.touched"></i>

         <input name="PPNumber" #PassportNumber="ngModel" [(ngModel)]="objservice.ppData.PassportNumber"

         placeholder="PPNumber" class="form-control" required maxlength="10" minlength="10">    

        </div></div>  </div>   </div>
             <div class="form-group">

            <div class="input-group">

            <div class="input-group-prepend">    

             <div class="input-group-text bg-white">

             <i class="fa fa-calendar" aria-hidden="true" [class.green-icon]="Expiry.valid"

              [class.red-icon]="Expiry.invalid && Expiry.touched"></i>

             <input name="PPExpirationDate" #Expiry="ngModel" [(ngModel)]="objservice.ppData.Expiry"

              placeholder="MM/YY"

              class="form-control" required maxlength="5" minlength="5">    

            </div></div>  </div>   </div>
                  
                  <div class="form-group">

                <div class="input-group">

                <div class="input-group-prepend">    

                 <div class="input-group-text bg-white">

                 <i class="fa fa-compass" aria-hidden="true"

                  [class.green-icon]="POCode.valid" [class.red-icon]="POCode.invalid && POCode.touched"></i>

                 <input name="PPOCode" #POCode="ngModel"

                 [(ngModel)]="objservice.ppData.POCode"

                  placeholder="POCode"

                  class="form-control" required

                  maxlength="6"

                  minlength="6">    

                </div></div>  </div>   </div>
                      <div class="form-group">

                  <button class="btn btn-success btn-lg"  type="submit"

                      [disabled]="form.invalid">

                     <i class="fa fa-database"></i> Create/Update Passport </button>  

                         </div>

</form>
