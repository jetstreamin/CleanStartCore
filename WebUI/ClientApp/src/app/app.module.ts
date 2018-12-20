import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { NavSideMenuComponent } from './nav-side-menu/nav-side-menu.component';
import { NavTopMenuComponent } from './nav-top-menu/nav-top-menu.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { IntermediariesComponent } from './intermediaries/intermediaries.component';

import { IntermediariesClient } from './gatesdsp-api';
import { AppRoutingModule } from './/app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    NavTopMenuComponent,
    NavSideMenuComponent,
    DashboardComponent,
    IntermediariesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [
    IntermediariesClient
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
