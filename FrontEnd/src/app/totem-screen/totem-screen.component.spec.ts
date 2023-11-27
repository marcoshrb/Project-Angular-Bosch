import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TotemScreenComponent } from './totem-screen.component';

describe('TotemScreenComponent', () => {
  let component: TotemScreenComponent;
  let fixture: ComponentFixture<TotemScreenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TotemScreenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TotemScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
