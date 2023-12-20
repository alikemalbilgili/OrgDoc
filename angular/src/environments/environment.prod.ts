import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'OrgDoc',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44376/',
    redirectUri: baseUrl,
    clientId: 'OrgDoc_App',
    responseType: 'code',
    scope: 'offline_access OrgDoc',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44376',
      rootNamespace: 'OrgDoc',
    },
  },
} as Environment;
