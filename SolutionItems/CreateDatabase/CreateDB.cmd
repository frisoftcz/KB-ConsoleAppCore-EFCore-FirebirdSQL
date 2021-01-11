DEL C:\DotNetCoreProjects\Console_EF_FB_1\Console_EF_FB_1\FBDatabase\FB_DATABASE_1.FDB
if exist C:\DotNetCoreProjects\Console_EF_FB_1\Console_EF_FB_1\FBDatabase\FB_DATABASE_1.FDB goto FAIL

isql -q -input CREATE_DATABASE.sql
isql -q -u SYSDBA -p masterkey -input UDF_DEF.sql
isql -q -u SYSDBA -p masterkey -input FB_DATABASE_1.sql
isql -q -u SYSDBA -p masterkey -input INSERT_DATA.sql

:FAIL
