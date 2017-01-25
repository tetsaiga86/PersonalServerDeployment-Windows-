# PersonalServerDeployment-Windows

## Introduction:
This is a c# form for deploying an express server over https. It uses node to create a local port and then is forwarded through ngrok. The api is meant to be paired with the android client that can be found here: https://github.com/tetsaiga86/PersonalServer-Android

## Directions For Setup:
The server and client have been set up with the end-user's ease of use in mind.
- Download the latest version, found here: .....
- Unzip to where you would like to install the server
- Install the included node.msi for your system
- Open My Personal Server.exe (found inside the Personal Server server folder)
- Select the directory that will serve as the root of your server
-- Please note that the client will not read hidden directories or files
- Select the node.exe file that was previously installed
- Select the port number (default: 3000)
- Click config and type in your username and password (default is Admin:password)
- Toggle any of the Checkbox options to suit your needs
- Click Apply 
- Click Start

If everything is working, the log field should display that the server has started and a QR code should appear on your screen.
Now you can start the android client and login using the QR code.

## Features:
- Server is HTTP service
- Runs using express
- Server forwarded through ngrok
- Api does not allow a client to access directories outside of the root folder (For example if the selected root is C:\Users\USERNAME\Music, the client will not have access to the C:\ drive)
- Autostart with windows
- Start in taskbar tray
- Autostart Server
- Logs server events in log file and displays them in textbox on windows form
- The Server API is set up to:
 * List all files and directories inside the root (except hidden/protected files)
 * transfer files to client
 * Zip and transfer directories to client
 * rename files and folders
 * delete files and folders
 * transfer files from client to server root
 * replace a currently existing file with a newer version

## Known issues:
- Uploading from client to server is not yet implemented on client app

## Coming Soon
More coming soon!
 
