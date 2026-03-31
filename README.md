# CyberBot - Cybersecurity Awareness Assistant

## Description
CyberBot is a console-based chatbot built in C# that educates users on cybersecurity threats. 
It was developed as part of a project for the Department of Cybersecurity's public awareness campaign. 
The bot covers topics such as phishing, password safety, safe browsing, and suspicious links.

## Features
- Voice greeting on launch using a WAV audio file
- ASCII art logo and coloured console UI
- Personalised responses using the user's name
- Keyword-based response system covering cybersecurity topics
- Input validation for empty and unrecognised inputs
- Typing effect and loading animation for a conversational feel
- Auto-returns to home screen after each response

## Project Structure
- Program.cs - Entry point and application flow control
- Responses.cs - Chatbot response logic and keyword detection
- UI.cs - All display formatting, colours, and visual effects

## How to Run
1. Clone the repository
2. Open the solution in Visual Studio
3. Build the project
4. Run the application

## Technologies Used
- C# (.NET 10)
- System.Media (SoundPlayer)
- System.Threading (Thread.Sleep)
- GitHub Actions for CI/CD

## References
- https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer
- https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep
- https://learn.microsoft.com/en-us/dotnet/api/system.console.foregroundcolor
- https://www.geeksforgeeks.org/thread-sleep-method-in-c-sharp/
- https://www.geeksforgeeks.org/how-to-play-a-sound-in-c-sharp/
- https://www.geeksforgeeks.org/console-foregroundcolor-property-in-c-sharp/

## Author
Zisanda Hlongwa
