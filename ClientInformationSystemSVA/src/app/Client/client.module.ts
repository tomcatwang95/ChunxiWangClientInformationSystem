import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientRoutingModule } from './client-routing.module';
import { ClientAppComponent } from './client-app.component';
import { UpdateclientComponent } from './updateclient/updateclient.component';
import { DeleteclientComponent } from './deleteclient/deleteclient.component';
import { ClientprofileComponent } from './clientprofile/clientprofile.component';
import { AddclientComponent } from './addclient/addclient.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ClientAppComponent,
    AddclientComponent,
    ClientprofileComponent,
    UpdateclientComponent,
    DeleteclientComponent
  ],
  imports: [
    CommonModule,
    ClientRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class ClientModule { }
