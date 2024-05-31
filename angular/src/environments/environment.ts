import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookStoreMeTech',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44355/',
    redirectUri: baseUrl,
    clientId: 'BookStoreMeTech_App',
    responseType: 'code',
    scope: 'offline_access BookStoreMeTech',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44355',
      rootNamespace: 'BookStoreMeTech',
    },
  },
} as Environment;
