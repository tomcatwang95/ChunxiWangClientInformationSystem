import { Component, OnInit } from '@angular/core';
import { EmployeeList } from 'src/app/Shared/Models/EmployeeList';
import { EmployeeService } from 'src/app/Core/Service/employee.service';

@Component({
  selector: 'app-employeeprofile',
  templateUrl: './employeeprofile.component.html',
  styleUrls: ['./employeeprofile.component.css']
})
export class EmployeeprofileComponent implements OnInit {

  employees!:EmployeeList[];

  constructor(private empolyeeservice: EmployeeService) { }

  ngOnInit(): void {
    this.empolyeeservice.getemployeelist().subscribe(
      e=>{
        this.employees=e;
        console.log('Inside this home component init method');
        console.table(this.employees); 
      }
    );
  }


}
