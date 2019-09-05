# iis-redirect-generator

The tool is designed for the easy creation of IIS redirects and postman tests. 

For IIS rewrite's I recommend using https://github.com/Bikeman868/UrlRewrite.Net which supports the same redirects as the standard IIS Rewrite modules. It does not have the limitation imposed with large .config files which causes issues when you have a large number of redirects and can't be fixed in Azure WebApps.

![Application](Docs/app.png)

The application loads .csv files that are expected to be formatted in 2 columns sich as the following attached file [Redirect Example](Docs/Book1.csv).

The application will escape and clean up invalid characters where possibe. Also the app can generate postman tests, in this case a postman v2 collection will be created with all the URls and check to match the status code and the redirect. These can then be imported to postman to run or run in the PostmanCLI. **To Note** You must disable following of redirects in the postman settings for these to work correctly.

The configuration for the app should be as follows

## General Settings

- **File** - This allows one of many files to be selected which will load all lines from the CSV files in for processing
- **Redirect Type** - The type of redirect to generate
- **Ignore Line 1** - Checked if the first line contains headings (as in the example)
- **Generate Redirects** - Should be checked if we want the rewrites generated
- **Match Domain** - If the match should do a domain match, usually true
- **Rule Name Start Index** - What number to start the naming of the direct rules
- **Rule Name Preix** - What prefix to use for the rules

Once these settings are configured clicking the Generate button will create the redirects.

## Postman Settings

- **Generate Postman Tests** - If to generate postman tests
- **Create For Every** - If to only create x lines if wanting to create a smaller subset
- **Collection Name** - The name of the collection that will be shown in postman
