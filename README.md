# address-book

1. in address-book-client folder run **npm i** in terminal
2. change proxy url in **src/configuration/proxy.conf.json** to .net Core localhost url
3. change connection string values in address-book-service/DAL/AddresBookContext :(
4. in address-book-service **package-manager-console** run:
* enable-migrations
* add-migration Initial -s DAL
* update-database -s DAL
**IMPORTANT: set DAL as your *Default project*