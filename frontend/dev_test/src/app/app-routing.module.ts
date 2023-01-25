import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UseListComponent } from './components/user/list/use-list.component';
import { UserAddComponent } from './components/user/create-update/user-add.component';

const routes: Routes = [
  { path: '', component: UseListComponent },
  { path: 'create-user', component: UserAddComponent },
  { path: 'user-list', component: UseListComponent },
  { path: 'create-survey', component: UseListComponent },
  { path: 'survey-list', component: UseListComponent },
  { path: 'participate-survey', component: UseListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
