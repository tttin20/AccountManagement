import { Component, OnInit } from '@angular/core';
import { AccountManagementService } from '../services/account-management.service';

@Component({
  selector: 'lib-account-management',
  template: ` <p>account-management works!</p> `,
  styles: [],
})
export class AccountManagementComponent implements OnInit {
  constructor(private service: AccountManagementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
