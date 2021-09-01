import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { EmployeeService } from 'src/app/Core/Service/employee.service';
import { Employee } from 'src/app/Shared/Models/Employee';

@Component({
  selector: 'app-updateemployee',
  templateUrl: './updateemployee.component.html',
  styleUrls: ['./updateemployee.component.css']
})
export class UpdateemployeeComponent implements OnInit {

  constructor(private employeeservice:EmployeeService) { }
  addemployee:Employee={
    name:'',
    password:'',
    Designation:''
  }

  Addsuccess!:Boolean;


  ngOnInit(): void {
    
  }
  updateemployee(f:NgForm)
  {
    this.employeeservice.updateemployee(this.addemployee).subscribe(
      (resp)=>{ if (resp){this.Addsuccess=true;}
      }
    );
  }

}
