import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { IntermediariesComponent } from './intermediaries/intermediaries.component';
import { DashboardComponent } from './dashboard/dashboard.component';

const routes: Routes =  [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'intermediaries', component: IntermediariesComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
