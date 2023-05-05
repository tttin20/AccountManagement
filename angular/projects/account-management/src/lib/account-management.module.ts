import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { AccountManagementComponent } from './components/account-management.component';
import { AccountManagementRoutingModule } from './account-management-routing.module';

@NgModule({
  declarations: [AccountManagementComponent],
  imports: [CoreModule, ThemeSharedModule, AccountManagementRoutingModule],
  exports: [AccountManagementComponent],
})
export class AccountManagementModule {
  static forChild(): ModuleWithProviders<AccountManagementModule> {
    return {
      ngModule: AccountManagementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<AccountManagementModule> {
    return new LazyModuleFactory(AccountManagementModule.forChild());
  }
}
