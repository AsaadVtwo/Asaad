import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { BsDropdownModule } from 'ngx-bootstrap';

import { AppComponent } from './app.component';

import { AlterifyService } from './_services/alterify.service';
import { VehicleFormComponent } from './vehicle-form/vehicle-form.component';
import { VegaRoutingModule } from './routes.module';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { HttpClient } from 'selenium-webdriver/http';


@NgModule({
  declarations: [
    AppComponent,
    VehicleFormComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    BsDropdownModule.forRoot()
  ],
  providers: [AuthService, AlterifyService],
  bootstrap: [AppComponent]
})
export class AppModule {}
