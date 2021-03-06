import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser'

import { InteractionRoutingModule } from './interaction-routing.module';
import { InteractionAppComponent } from './interaction-app.component';
import { AddinteractionComponent } from './addinteraction/addinteraction.component';
import { UpdateinteractionComponent } from './updateinteraction/updateinteraction.component';
import { DeleteinteractionComponent } from './deleteinteraction/deleteinteraction.component';
import { InteractionprofileComponent } from './interactionprofile/interactionprofile.component';


@NgModule({
  declarations: [
    InteractionAppComponent,
    InteractionprofileComponent,
    AddinteractionComponent,
    UpdateinteractionComponent,
    DeleteinteractionComponent
  ],
  imports: [
    CommonModule,
    InteractionRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class InteractionModule { }
