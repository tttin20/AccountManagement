import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { AccountManagementComponent } from './components/account-management.component';
import { AccountManagementService } from '@account-management';
import { of } from 'rxjs';

describe('AccountManagementComponent', () => {
  let component: AccountManagementComponent;
  let fixture: ComponentFixture<AccountManagementComponent>;
  const mockAccountManagementService = jasmine.createSpyObj('AccountManagementService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [AccountManagementComponent],
      providers: [
        {
          provide: AccountManagementService,
          useValue: mockAccountManagementService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AccountManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
