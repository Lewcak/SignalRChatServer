# C# SignalR Real-Time Chat

This is a real-time chat application built using the core concepts of C# ASP.NET Core and SignalR.

---

## Technologies Used

* **.NET (C#):** For the web server and backend logic.

* **SignalR:** The core library for handling real-time communication between the server and clients.

* **ASP.NET Core:** The web framework used to host the SignalR hub.

* **HTML/CSS/JavaScript:** For the client-side chat interface.

* **Tailwind CSS:** Used CDN for styling.

## How to Run This Project

1) ### Run the Server

* You must have atleast .NET 8 SDK installed.

* Navigate to the server project directory
```bash
cd SignalRChatServer
```
* Run the server 
```bash
dotnet run
```
* The server will start, check the the localhost URL

2) ### Run the Client

* Make sure the server is running.

* In the 'index.html' file, check the hubUrl variable and ensure the port number matches the one your server is running on.

* Open the 'index.html' file a web browser.

* Open a second 'index.html' in another browser window to chat. 
