import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ShowComponent } from './show/show.component';
import { CreateComponent } from './create/create.component';
import { DetailViewComponent } from './detail-view/detail-view.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'show', component: ShowComponent },
  { path: 'create', component: CreateComponent },
  { path: 'create/:id', component: CreateComponent },
  { path: 'detail-view/:id', component: DetailViewComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
