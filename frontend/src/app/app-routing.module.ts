import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { routes } from './app.routes';

// Define the AppRoutingModule
@NgModule({
  imports: [RouterModule.forRoot(routes)], // Import the routes into the RouterModule
  exports: [RouterModule] // Export the RouterModule to make it available throughout the app
})
export class AppRoutingModule { }
