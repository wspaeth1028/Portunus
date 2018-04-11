# Portunus
A new Console App to replace File Move and all subsidiaries of.
  Replacements include AutoKey, File Move, Multos File Move (SC, SM, MSM), Atlas File Move

Designed to be a one stop shop for all file move functions on either Corp or Secure.
Designed to be simply deployed without the need to change any configuration or anything, even when deploying to Corp or Secure.
Configuration for every file move function will be Database driven, with the database shared (in the background) between Corp and Secure.
Also replaces the old SecureBlackbox sFTP dll package with an open source sFTP called Renci.SSH.NET from Nuget.
  -This is to allow for more visibility into our sFTP processes.
Each move function will be allowed to have a pre/post process path to do extra processing other than simply moving files
  -This will alow things like AutoKey to have all its functionality in Portunus without affecting other file move operations.
  -Each Pre/Post Process will have a class/set of classes to house its individual functionality
