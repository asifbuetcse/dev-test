import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UseListComponent } from './components/user/list/use-list.component';
import { UserAddComponent } from './components/user/create-update/user-add.component';
import { SurveyAddComponent } from './components/survey/create-update/survey-add/survey-add.component';
import { SurveyListComponent } from './components/survey/list/survey-list/survey-list.component';

const routes: Routes = [
  { path: '', component: UseListComponent },
  { path: 'create-user', component: UserAddComponent },
  { path: 'user-list', component: UseListComponent },
  { path: 'create-survey', component: SurveyAddComponent },
  { path: 'survey-list', component: SurveyListComponent },
  { path: 'participate-survey', component: UseListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
