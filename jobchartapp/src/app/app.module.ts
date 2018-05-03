import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { HttpClientModule } from '@angular/common/http';
import { MatButtonModule, MatTabsModule, MatCardModule } from '@angular/material';

import { ChartModule } from 'angular-highcharts';

import { AppComponent } from './app.component';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, BrowserAnimationsModule,
    HttpClientModule,

    MatButtonModule,
    MatTabsModule,
    MatCardModule,

    ChartModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
