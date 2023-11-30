import { Routes } from '@angular/router';
import { AdmScreenComponent } from './adm-screen/adm-screen.component';
import { LoginComponent } from './login/login.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { PedidosScreenComponent } from './pedidos-screen/pedidos-screen.component';
import { ClienteScreenComponent } from './cliente-screen/cliente-screen.component';
import { ProdutosScreenComponent } from './produtos-screen/produtos-screen.component';
import { TotemScreenComponent } from './totem-screen/totem-screen.component';

export const routes: Routes = [
    {path : '', component : LoginComponent},
    {path : 'cadastro', component : CadastroComponent},
    {path : 'adm', component : AdmScreenComponent},
    {path : 'pedidos', component : PedidosScreenComponent},
    {path : 'cliente', component : ClienteScreenComponent},
    {path : 'produtos', component : ProdutosScreenComponent},
    {path : 'totem', component : TotemScreenComponent}
];
