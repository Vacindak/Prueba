import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CrearComponent } from './pages/crear/crear.component';
import { ListarComponent } from './pages/listar/listar.component';

const routes: Routes = [

{path:"crear",component:CrearComponent},
{path:"listar",component:ListarComponent},
{path:"**",pathMatch:"full",redirectTo:"listar"}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]


})
export class AppRoutingModule { }
