
const yourIP = 'Your Local IP Address etc 192.168.1.64'; // See the docs https://docs.abp.io/en/abp/latest/Getting-Started-React-Native?Tiered=No
const port  = 44305;
const apiUrl = `http://${yourIP}:${port}`;
const ENV = {
  dev: {
    apiUrl: apiUrl,
    oAuthConfig: {
      issuer: apiUrl,
      clientId: 'OrgDoc_App',
      scope: 'offline_access OrgDoc',
    },
    localization: {
      defaultResourceName: 'OrgDoc',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44376',
    oAuthConfig: {
      issuer: 'http://localhost:44376',
      clientId: 'OrgDoc_App',
      scope: 'offline_access OrgDoc',
    },
    localization: {
      defaultResourceName: 'OrgDoc',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
