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


.trainer-card {
    border: 1px solid #ccc;
    padding: 20px;
    margin: 10px;
    border-radius: 5px;
}

.btn-group {
    margin-top: 10px;
}

.btn-group button {
    margin-right: 10px;
}

<div class="container">
    <div class="trainer-card" *ngFor="let trainer of trainers">
        <h3 class="secondary mb">{{trainer.firstName}} {{trainer.lastName}}</h3>
        <p class="tertiary mb">Date of Birth: {{trainer.dateOfBirth}}</p>
        <p class="tertiary mb">Gender: {{trainer.gender}}</p>
        <p class="tertiary mb">Contact Number: {{trainer.contactNumber}}</p>
        <p class="tertiary mb">Email: {{trainer.email}}</p>
        <p class="tertiary mb">Hire Date: {{trainer.hireDate}}</p>
        <p class="tertiary mb">Specialization: {{trainer.specialization}}</p>
        <div class="btn-group">
            <button class="btn bt" (click)="onUpdate(trainer)">Update</button>
            <button class="btn bt" (click)="onDelete(trainer)">Delete</button>
        </div>
    </div>
</div>

import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-display',
    templateUrl: './display.component.html',
    styleUrls: ['./display.component.css']
})
export class DisplayComponent implements OnInit {
    trainers = [
        {
            firstName: 'John',
            lastName: 'Doe',
            dateOfBirth: '1990-01-01',
            gender: 'Male',
            contactNumber: '1234567890',
            email: 'john.doe@example.com',
            hireDate: '2022-01-01',
            specialization: 'Fitness'
        },
        // ... other trainers
    ];

    constructor() { }

    ngOnInit(): void {
    }

    onUpdate(trainer): void {
        console.log('Update trainer:', trainer);
        // ... implement your update logic
    }

    onDelete(trainer): void {
        console.log('Delete trainer:', trainer);
        // ... implement your delete logic
    }
}

.form-group {
    margin-bottom: 15px;
}

.form-group label {
    display: block;
}

.form-group input {
    width: 100%;
    padding: 10px;
    border-radius: 5px;
    border: 1px solid #ccc;
}

<div class="container">
    <form (submit)="onSubmit()">
        <div class="form-group">
            <label for="firstName">First Name</label>
            <input type="text" id="firstName" [(ngModel)]="trainer.firstName" name="firstName" required>
        </div>
        <div class="form-group">
            <label for="lastName">Last Name</label>
            <input type="text" id="lastName" [(ngModel)]="trainer.lastName" name="lastName" required>
        </div>
        <div class="form-group">
            <label for="dateOfBirth">Date of Birth</label>
            <input type="date" id="dateOfBirth" [(ngModel)]="trainer.dateOfBirth" name="dateOfBirth" required>
        </div>
        <div class="form-group">
            <label for="gender">Gender</label>
            <input type="text" id="gender" [(ngModel)]="trainer.gender" name="gender" required>
        </div>
        <div class="form-group">
            <label for="contactNumber">Contact Number</label>
            <input type="text" id="contactNumber" [(ngModel)]="trainer.contactNumber" name="contactNumber" required>
        </div>
        <div class="form-group">
            <label for="email">Email</label>
            <input type="email" id="email" [(ngModel)]="trainer.email" name="email" required>
        </div>
        <div class="form-group">
            <label for="hireDate">Hire Date</label>
            <input type="date" id="hireDate" [(ngModel)]="trainer.hireDate" name="hireDate" required>
        </div>
        <div class="form-group">
            <label for="specialization">Specialization</label>
            <input type="text" id="specialization" [(ngModel)]="trainer.specialization" name="specialization" required>
        </div>
        <button type="submit" class="btn bt">Register</button>
    </form>
</div>

import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
    selector: 'app-reg',
    templateUrl: './reg.component.html',
    styleUrls: ['./reg.component.css']
})
export class RegComponent implements OnInit {
    trainer = {
        firstName: '',
        lastName: '',
        dateOfBirth: '',
        gender: '',
        contactNumber: '',
        email: '',
        hireDate: '',
        specialization: ''
    };

    constructor() { }

    ngOnInit(): void {
    }

    onSubmit(form: NgForm): void {
        console.log('Form submitted:', form.value);
        // ... send form data to the server
    }
}


<form #form="ngForm" autocomplete="off" (submit)="onSubmit(form)">
    <input type="hidden" name="ID" [value]="objService.attendanceData.attendanceID">
    <div class="form-group">
        <div class="input-group">
            <div class="input-group-prepend">
                <div class="input-group-text bg-white">
                    <i class="fa fa-user-circle-o" aria-hidden="true" [class.green-icon]='objService.attendanceData.attendanceID.valid'
                    [class.red-icon]="objService.attendanceData.attendanceID.invalid && objService.attendanceData.attendanceID.touched"></i>
                    <input name="attendanceID" #attendanceID="ngModel" [(ngModel)]="objService.attendanceData.attendanceID" placeholder="Attendance ID" class="form-control" required>
                </div>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="input-group">
            <div class="input-group-prepend">
                <div class="input-group-text bg-white">
                    <i class="fa fa-diamond" aria-hidden="true" [class.green-icon]='objService.attendanceData.memberID.valid'
                    [class.red-icon]="objService.attendanceData.memberID.invalid && objService.attendanceData.memberID.touched"></i>
                    <input name="memberID" #memberID="ngModel" [(ngModel)]="objService.attendanceData.memberID" placeholder="member ID" class="form-control" required>
                </div>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="input-group">
            <div class="input-group-prepend">
                <div class="input-group-text bg-white">
                    <i class="fa fa-calender" aria-hidden="true" [class.green-icon]='objService.attendanceData.AttendanceDate.valid'
                    [class.red-icon]="objService.attendanceData.AttendanceDate.invalid && objService.attendanceData.AttendanceDate.touched"></i>
                    <input name="AttendanceDate" #AttendanceDate="ngModel" [(ngModel)]="objService.attendanceData.AttendanceDate" placeholder="Attendance Date" class="form-control" required>
                </div>
            </div>
        </div>
    </div>
    <div class="form-group">
        <button class="btn btn-success btn-lg" type="submit" [disabled]="form.invalid">
            <i class="fa fa-database"></i> Create/Update Branch </button>
    </div>
</form>
import { Component,OnInit } from '@angular/core';
import { AttendancesService } from 'src/app/shared/attendances.service';
import { Attendances } from 'src/app/shared/attendances.model';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-reg',
  templateUrl: './reg.component.html',
  styleUrls: ['./reg.component.css']
})
export class RegComponent implements OnInit{
  
  constructor(public objService:AttendancesService){}
  ngOnInit(): void {
    this.resetForm();
  }
  resetForm(form?:NgForm)
  {
    if(form!=null){form.form.reset();}
    else{this.objService.attendanceData={attendanceID:0,memberID:0,classID:0,AttendanceDate:''}}
  }
  onSubmit(form:NgForm)
  {
    if(this.objService.attendanceData.attendanceID=0){
      this.insertRecord(form);
    }
    else{
      this.updateRecord(form);
    }
  }
  insertRecord(form:NgForm){
    this.objService.postAttendance().subscribe(res=>{this.resetForm(form);this.objService.getAttendanceList();alert('Attendance Registered Successfully');},err=>{alert('Error !!!'+err);})
  }
  updateRecord(form:NgForm){
    this.objService.putAttendance().subscribe(res=>{this.resetForm(form);this.objService.getAttendanceList();alert('Attendance Updated Successfully');},err=>{alert('Error !!!'+err);})
  }
}


        
    

