import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';

import { AlterifyService } from './_services/alterify.service';
import { VehicleFormComponent } from './vehicle-form/vehicle-form.component';
import { VegaRoutingModule } from './routes.module';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { HttpClient } from 'selenium-webdriver/http';
import { HttpClientModule } from '@angular/common/http';
import { JwtModule, JwtModuleOptions } from '@auth0/angular-jwt';

const JWT_Module_Options: JwtModuleOptions = {
  config: {
    tokenGetter: () => {
      return localStorage.getItem('token');
    }
  }
};

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
    HttpClientModule,
    JwtModule.forRoot(JWT_Module_Options)
  ],
  providers: [AuthService, AlterifyService],
  bootstrap: [AppComponent]
})
export class AppModule {}
