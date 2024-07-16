import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';  // Import CommonModule

import { AppComponent } from './app.component';
import { CreateComponent } from './create/create.component';
import { ShowComponent } from './show/show.component';
import { DetailViewComponent } from './detail-view/detail-view.component';  // Ensure this is imported
import { AppRoutingModule } from './app-routing.module';  // Assuming you have routing

@NgModule({
  declarations: [
    AppComponent,
    CreateComponent,
    ShowComponent,
    DetailViewComponent  // Declare DetailViewComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    CommonModule,  // Include CommonModule
    AppRoutingModule  // Assuming you have routing
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
