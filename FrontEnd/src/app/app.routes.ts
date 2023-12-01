import { Routes } from '@angular/router';
import { AdmScreenComponent } from './adm-screen/adm-screen.component';
import { LoginComponent } from './login/login.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { PedidosScreenComponent } from './pedidos-screen/pedidos-screen.component';
import { ClienteScreenComponent } from './cliente-screen/cliente-screen.component';
import { ProdutosScreenComponent } from './produtos-screen/produtos-screen.component';
import { TotemScreenComponent } from './totem-screen/totem-screen.component';
import { UserGuard } from './guard/user.gard';

export const routes: Routes = [
    {path : '', component : LoginComponent},
    {path : 'cadastro', component : CadastroComponent },
    {path : 'adm', component : AdmScreenComponent, canActivate: [UserGuard] },
    {path : 'pedidos', component : PedidosScreenComponent, canActivate: [UserGuard] },
    {path : 'cliente', component : ClienteScreenComponent, canActivate: [UserGuard] },
    {path : 'produtos', component : ProdutosScreenComponent, canActivate: [UserGuard] },
    {path : 'totem', component : TotemScreenComponent, canActivate: [UserGuard] },
    { path: '', redirectTo: '', pathMatch: 'full' }
];
