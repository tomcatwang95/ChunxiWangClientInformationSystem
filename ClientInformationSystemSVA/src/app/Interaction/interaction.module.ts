import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
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
    CommonModule,
    InteractionRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class InteractionModule { }
