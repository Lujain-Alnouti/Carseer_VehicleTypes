import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarModelsViewComponent } from './car-models-view.component';

describe('CarModelsViewComponent', () => {
  let component: CarModelsViewComponent;
  let fixture: ComponentFixture<CarModelsViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarModelsViewComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CarModelsViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
