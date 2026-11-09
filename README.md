# WeAreCars

A Windows Forms car-rental booking application built with .NET 8.

## Run

Set the staff login password in the environment, then launch the application:

```powershell
$env:WEARECARS_STAFF_PASSWORD = 'replace-with-a-private-password'
dotnet run --project .\WeAreCars\WeAreCars.csproj
```

The staff username is `sta001`. The password must be configured before opening
the app; there is no default password. Keep the configured password private and
do not commit it to source control.

Bookings are stored locally under the current user's application data folder.

## Test

```powershell
dotnet test .\WeAreCars.sln
```
