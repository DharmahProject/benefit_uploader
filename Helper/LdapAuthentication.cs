using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.DirectoryServices;

namespace BenefitUploader.Helper
{
    public class LdapAuthentication 
    {
        string _path;
        string _filterAttribute;

        public LdapAuthentication(string path)
        {
            _path = path;
        }

        public bool IsAuthenticated(string domain, string username, string pwd)
        {
            bool bAuth = false;

            string domainAndUsername = username;
            DirectoryEntry entry = new DirectoryEntry(_path, domainAndUsername, pwd);

            try
            {
                object obj = entry.NativeObject;
                DirectorySearcher search = new DirectorySearcher(entry);

                search.Filter = "(SAMAccountName=" + username + ")";
                search.PropertiesToLoad.Add("cn");
                SearchResult result = search.FindOne();

                bAuth = true;
                if ((result == null))
                {
                    bAuth = false;
                }

                _path = result.Path;
                _filterAttribute = Convert.ToString(result.Properties["cn"][0]);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return bAuth;
        }

        public string GetGroups()
        {
            DirectorySearcher search = new DirectorySearcher(_path);
            search.Filter = "(cn=" + _filterAttribute + ")";
            search.PropertiesToLoad.Add("memberOf");
            StringBuilder groupNames = new StringBuilder();

            try
            {
                SearchResult result = search.FindOne();
                int propertyCount = result.Properties["memberOf"].Count;

                string dn = null;
                int equalsIndex = 0;
                int commaIndex = 0;

                int propertyCounter = 0;

                for (propertyCounter = 0; propertyCounter <= propertyCount - 1; propertyCounter++)
                {
                    dn = Convert.ToString(result.Properties["memberOf"][propertyCounter]);

                    equalsIndex = dn.IndexOf("=", 1);
                    commaIndex = dn.IndexOf(",", 1);
                    if ((equalsIndex == -1))
                    {
                        return null;
                    }

                    groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1));
                    groupNames.Append("|");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return groupNames.ToString();
        }
    }
}
