import { BrowserModule } from '@angular/platform-browser';
import { NgModule, importProvidersFrom } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [], // Add services here if needed
})
export class AppModule { }
