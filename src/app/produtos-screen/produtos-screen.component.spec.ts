import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutosScreenComponent } from './produtos-screen.component';

describe('ProdutosScreenComponent', () => {
  let component: ProdutosScreenComponent;
  let fixture: ComponentFixture<ProdutosScreenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProdutosScreenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProdutosScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
