import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsersComponent } from './users/users.component';
import { EInfoComponent } from './e-info/e-info.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ViewchildComponent } from './viewchild/viewchild.component';

@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    EInfoComponent,
    ViewchildComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
