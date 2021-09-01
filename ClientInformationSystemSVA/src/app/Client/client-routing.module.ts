import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddclientComponent } from './addclient/addclient.component';
import { ClientAppComponent } from './client-app.component';
import { ClientprofileComponent } from './clientprofile/clientprofile.component';
import { DeleteclientComponent } from './deleteclient/deleteclient.component';
import { UpdateclientComponent } from './updateclient/updateclient.component';

const routes: Routes = [
  {
    path:"", component:ClientAppComponent,
    children:[
      {path:"listall", component: ClientprofileComponent}, 
      {path:"create", component: AddclientComponent},
      {path:"update", component:UpdateclientComponent},
      {path:"delete", component:DeleteclientComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClientRoutingModule { }
