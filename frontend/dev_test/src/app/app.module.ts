import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UseListComponent } from './components/user/list/use-list.component';

import { HttpClientModule } from '@angular/common/http';
import { UserAddComponent } from './components/user/create-update/user-add.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SurveyListComponent } from './components/survey/list/survey-list/survey-list.component';
import { SurveyAddComponent } from './components/survey/create-update/survey-add/survey-add.component';

@NgModule({
  declarations: [
    AppComponent,
    UseListComponent,
    UserAddComponent,
    SurveyListComponent,
    SurveyAddComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
