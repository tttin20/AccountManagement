import { TestBed } from '@angular/core/testing';
import { AccountManagementService } from './services/account-management.service';
import { RestService } from '@abp/ng.core';

describe('AccountManagementService', () => {
  let service: AccountManagementService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(AccountManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
