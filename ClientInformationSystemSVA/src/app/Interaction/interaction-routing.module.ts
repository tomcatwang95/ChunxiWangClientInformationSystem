import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddinteractionComponent } from './addinteraction/addinteraction.component';
import { DeleteinteractionComponent } from './deleteinteraction/deleteinteraction.component';
import { InteractionAppComponent } from './interaction-app.component';
import { InteractionprofileComponent } from './interactionprofile/interactionprofile.component';
import { UpdateinteractionComponent } from './updateinteraction/updateinteraction.component';

const routes: Routes = [
  {
    path:"", component:InteractionAppComponent,
    children:[
      {path:"listall", component: InteractionprofileComponent}, 
      {path:"create", component: AddinteractionComponent},
      {path:"update", component:UpdateinteractionComponent},
      {path:"delete", component:DeleteinteractionComponent}
    ]
  }
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InteractionRoutingModule { }
