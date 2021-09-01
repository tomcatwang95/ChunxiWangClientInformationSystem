import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { EmployeeService } from 'src/app/Core/Service/employee.service';
import { Employee } from 'src/app/Shared/Models/Employee';

@Component({
  selector: 'app-addemployee',
  templateUrl: './addemployee.component.html',
  styleUrls: ['./addemployee.component.css']
})
export class AddemployeeComponent implements OnInit {

  constructor(private employeeservice:EmployeeService) { }
  addemployee:Employee={
    name:'',
    password:'',
    Designation:''
  }

  Addsuccess!:Boolean;


  ngOnInit(): void {
    
  }
  createemployee(f:NgForm)
  {
    this.employeeservice.createemployee(this.addemployee).subscribe(
      (resp)=>{ if (resp){this.Addsuccess=true;}
      }
    );
  }

}
