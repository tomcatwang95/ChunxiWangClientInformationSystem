import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Account/login/login.component';
import { LogoutComponent } from './Account/logout/logout.component';
import { HomeComponent } from './home/home.component';
import { InteractionprofileComponent } from './Interaction/interactionprofile/interactionprofile.component';

const routes: Routes = [
  {path:"", component:HomeComponent},
  {path:"Account/login", component:LoginComponent},
  {path:"Account/logout", component:LogoutComponent},
  {path:"Interaction/listall", component:InteractionprofileComponent},
  {path:"Client", loadChildren:()=>import('./Client/client.module').then(mod=>mod.ClientModule)},
  {path:"Employee", loadChildren:()=>import('./Employee/employee.module').then(mod=>mod.EmployeeModule)},
  {path:"Interaction", loadChildren:()=>import('./Interaction/interaction.module').then(mod=>mod.InteractionModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
