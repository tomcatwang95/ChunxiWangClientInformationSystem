import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { InteractionRoutingModule } from './interaction-routing.module';
import { InteractionAppComponent } from './interaction-app.component';
import { RouterLink } from '@angular/router';
import { AddinteractionComponent } from './addinteraction/addinteraction.component';
import { UpdateinteractionComponent } from './updateinteraction/updateinteraction.component';
import { DeleteinteractionComponent } from './deleteinteraction/deleteinteraction.component';


@NgModule({
  declarations: [
    InteractionAppComponent,
    AddinteractionComponent,
    UpdateinteractionComponent,
    DeleteinteractionComponent
  ],
  imports: [
    InteractionRoutingModule,
    RouterLink,
    ReactiveFormsModule
  ]
})
export class InteractionModule { }
