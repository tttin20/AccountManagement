import { ModuleWithProviders, NgModule } from '@angular/core';
import { ACCOUNT_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class AccountManagementConfigModule {
  static forRoot(): ModuleWithProviders<AccountManagementConfigModule> {
    return {
      ngModule: AccountManagementConfigModule,
      providers: [ACCOUNT_MANAGEMENT_ROUTE_PROVIDERS],
    };
  }
}
