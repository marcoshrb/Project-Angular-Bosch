import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdmScreenComponent } from './adm-screen.component';

describe('AdmScreenComponent', () => {
  let component: AdmScreenComponent;
  let fixture: ComponentFixture<AdmScreenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdmScreenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AdmScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
