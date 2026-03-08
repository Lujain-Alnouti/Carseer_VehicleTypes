import { Routes } from '@angular/router';
import { CarModelsViewComponent } from './components/car-models-view/car-models-view.component';

export const routes: Routes = [

    {
    path: 'CarModels',
    component: CarModelsViewComponent
  },

  {
    path: '',
    redirectTo: 'CarModels',
    pathMatch: 'full'
  }
];
