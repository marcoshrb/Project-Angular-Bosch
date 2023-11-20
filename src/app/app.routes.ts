import { Routes } from '@angular/router';
import { AdmScreenComponent } from './adm-screen/adm-screen.component';
import { LoginComponent } from './login/login.component';

export const routes: Routes = [
    {path : 'AdmScreenComponent', component : AdmScreenComponent},
    {path : '', component : LoginComponent}
];
