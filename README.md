# Portunus
A new Console App to replace File Move and all subsidiaries of.

Designed to be a one stop shop for all file move functions on either Corp or Secure.
Designed to be simply deployed without the need to change any configuration or anything, even when deploying to Corp or Secure.
Configuration for every file move function will be Database driven, with the database shared (in the background) between Corp and Secure.
Also replaces the old SecureBlackbox sFTP dll package with an open source sFTP called Renci.SSH.NET from Nuget.
This is to allow for more visibility into our sFTP processes.
