import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';


const VegaRoutes: Routes = [];

@NgModule({
  imports: [
    RouterModule.forChild(VegaRoutes)
  ],
  exports: [
    RouterModule
  ]
})
export class VegaRoutingModule { }
