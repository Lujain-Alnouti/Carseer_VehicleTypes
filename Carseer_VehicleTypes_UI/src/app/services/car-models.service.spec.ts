import { TestBed } from '@angular/core/testing';

import { CarModelsService } from './car-models.service';

describe('CarModelsService', () => {
  let service: CarModelsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CarModelsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
