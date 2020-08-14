import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ModuleplayerComponent} from './moduleplayer/moduleplayer.component';


const routes: Routes = [
  {path: 'moduleplayer/:id', component: ModuleplayerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
