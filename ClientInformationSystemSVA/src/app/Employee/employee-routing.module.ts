import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { DeleteemployeeComponent } from './deleteemployee/deleteemployee.component';
import { EmployeeAppComponent } from './employee-app.component';
import { EmployeeModule } from './employee.module';
import { EmployeeprofileComponent } from './employeeprofile/employeeprofile.component';
import { UpdateemployeeComponent } from './updateemployee/updateemployee.component';

const routes: Routes = [
  {
    path:"", component:EmployeeAppComponent,
    children:[
      {path:"listall", component: EmployeeprofileComponent}, 
      {path:"create", component: AddemployeeComponent},
      {path:"update", component:UpdateemployeeComponent},
      {path:"delete", component:DeleteemployeeComponent}
    ]
  }
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmployeeRoutingModule { }
