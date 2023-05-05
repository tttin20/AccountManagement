import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class AccountManagementService {
  apiName = 'AccountManagement';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/AccountManagement/sample' },
      { apiName: this.apiName }
    );
  }
}
