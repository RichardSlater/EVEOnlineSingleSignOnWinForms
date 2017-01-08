EVE Online SSO from a Windows Forms Application
===============================================

This application demonstrates how to initiate a sign-on and capture authorization, access and refresh tokens from the EVE Online Single Sign On Service.

![Demo][demo]

## Advantages

 * Does not depend on Operating System capabilities, only .NET framework functionality and a small number of NuGet packages.

## Disadvantages

 * Will fail if the selected port is already in use...
  * ... *Mitigation*: register two or more separate applications with CCP using different ports for the redirect URL, if OWIN fails to bind to one port try the other port.
 * May cause "Windows Firewall" warnings under some circumstances.
  * ... *Mitigation*: warn the user in advance that Windows Firewall may display a message allowing.
 * Client ID and Secret exposed to all users.
  * ... *Mitigation*: None that I can think of.

   [demo]: content/EVESSO.gif
