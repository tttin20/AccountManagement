import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'AccountManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44335/',
    redirectUri: baseUrl,
    clientId: 'AccountManagement_App',
    responseType: 'code',
    scope: 'offline_access AccountManagement',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44335',
      rootNamespace: 'AccountManagement',
    },
    AccountManagement: {
      url: 'https://localhost:44392',
      rootNamespace: 'AccountManagement',
    },
  },
} as Environment;
