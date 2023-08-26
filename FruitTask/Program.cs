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


{
  "attendanceId": 0,
  "memberId": 0,
  "classId": 0,
  "attendanceDate": "2023-08-26T16:45:15.188Z",
  "class": {
    "classId": 0,
    "className": "string",
    "description": "string",
    "schedule": "string",
    "trainerId": 0,
    "maxCapacity": 0,
    "attendances": [
      "string"
    ],
    "trainer": {
      "trainerId": 0,
      "firstName": "string",
      "lastName": "string",
      "dateOfBirth": "2023-08-26T16:45:15.188Z",
      "gender": "string",
      "contactNumber": "string",
      "email": "string",
      "hireDate": "2023-08-26T16:45:15.188Z",
      "specialization": "string",
      "classes": [
        "string"
      ]
    }
  },
  "member": {
    "memberId": 0,
    "firstName": "string",
    "lastName": "string",
    "dateOfBirth": "2023-08-26T16:45:15.188Z",
    "gender": "string",
    "contactNumber": "string",
    "email": "string",
    "joinDate": "2023-08-26T16:45:15.188Z",
    "attendances": [
      "string"
    ],
    "payments": [
      {
        "paymentId": 0,
        "memberId": 0,
        "paymentDate": "2023-08-26T16:45:15.188Z",
        "amount": 0,
        "paymentType": "string",
        "member": "string"
      }
    ],
    "subscriptions": [
      {
        "subscriptionId": 0,
        "memberId": 0,
        "startDate": "2023-08-26T16:45:15.188Z",
        "endDate": "2023-08-26T16:45:15.188Z",
        "subscriptionType": "string",
        "amountPaid": 0,
        "member": "string"
      }
    ]
  }
} 
        {
  "attendanceId": 1,
  "memberId": 1,
  "classId": 1,
  "attendanceDate": "2023-08-26T16:45:15.188Z",
  "class": {
    "classId": 1,
    "className": "Strength Training",
    "description": "A class focused on building muscle and strength.",
    "schedule": "Monday, Wednesday, Friday - 10:00 AM",
    "trainerId": 1,
    "maxCapacity": 20,
    "attendances": [
      "1"
    ],
    "trainer": {
      "trainerId": 1,
      "firstName": "Mike",
      "lastName": "Smith",
      "dateOfBirth": "1980-01-01T00:00:00.000Z",
      "gender": "Male",
      "contactNumber": "+1122334455",
      "email": "mikesmith@example.com",
      "hireDate": "2022-01-01T00:00:00.000Z",
      "specialization": "Strength Training",
      "classes": [
        "1"
      ]
    }
  },
  "member": {
    "memberId": 1,
    "firstName": "John",
    "lastName": "Doe",
    "dateOfBirth": "1985-01-01T00:00:00.000Z",
    "gender": "Male",
    "contactNumber": "+1234567890",
    "email": "johndoe@example.com",
    "joinDate": "2023-01-01T00:00:00.000Z",
    "attendances": [
      "1"
    ],
    "payments": [
      {
        "paymentId": 1,
        "memberId": 1,
        "paymentDate": "2023-01-01T00:00:00.000Z",
        "amount": 1200.00,
        "paymentType": "Credit Card",
        "member": "1"
      }
    ],
    "subscriptions": [
      {
        "subscriptionId": 1,
        "memberId": 1,
        "startDate": "2023-01-01T00:00:00.000Z",
        "endDate": "2023-12-31T00:00:00.000Z",
        "subscriptionType": "Annual",
        "amountPaid": 1200.00,
        "member": "1"
      }
    ]
  }
        }
        {
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "00-82e12d4c5e8bb900b1381161630a9bd9-c50437042bdcb9d7-00",
  "errors": {
    "attendance": [
      "The attendance field is required."
    ],
    "$.class.trainer.classes[0]": [
      "The JSON value could not be converted to GymManagementSystem.Models.Class. Path: $.class.trainer.classes[0] | LineNumber: 32 | BytePositionInLine: 11."
    ]
  }
}
        
                         
