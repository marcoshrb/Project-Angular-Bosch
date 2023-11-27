import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PedidosScreenComponent } from './pedidos-screen.component';

describe('PedidosScreenComponent', () => {
  let component: PedidosScreenComponent;
  let fixture: ComponentFixture<PedidosScreenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PedidosScreenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PedidosScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
