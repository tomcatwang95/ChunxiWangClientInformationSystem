import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { EmployeeService } from 'src/app/Core/Service/employee.service';

@Component({
  selector: 'app-deleteemployee',
  templateUrl: './deleteemployee.component.html',
  styleUrls: ['./deleteemployee.component.css']
})
export class DeleteemployeeComponent implements OnInit {

  constructor(private employeeservice:EmployeeService) { }
  Deletesuccess!:Boolean;
  id!: number;
  ngOnInit(): void {
    
  }
  deleteclient(f:NgForm)
  {
    this.employeeservice.deleteclient(this.id).subscribe(
      (resp)=>{ if (resp){this.Deletesuccess=true;}
      }
    );
  }

}
