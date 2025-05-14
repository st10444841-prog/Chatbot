# Cybersecurity Awareness Chatbot Project

This project is a two-part interactive chatbot system developed using **C#**. It is designed to promote cybersecurity awareness by engaging users in conversations about safe online practices.

---

## Part 1 – Introductory Console Chatbot  
**Namespace:** `poepart1`

### Overview
Part 1 introduces a simple chatbot that uses audio, ASCII visuals, and basic keyword recognition to interact with the user.

### Key Features
- Plays a greeting audio file (`greeting.wav`) at startup
- Displays a colored ASCII art cybersecurity logo
- Asks the user for their name and provides a personalized greeting
- Offers basic responses to common cybersecurity keywords:
  - Password safety
  - Phishing
  - Safe browsing
- Case-insensitive input handling
- Graceful exit using the command `exit`
- Handles empty input gracefully

### Sample Inputs
- `how are you`
- `password safety`
- `phishing`
- `safe browsing`
- `exit`

---

## Part 2 – Enhanced Modular Chatbot  
**Namespace:** `CybersecurityChatbot`

### Overview
Part 2 expands on the chatbot by introducing a class-based architecture (`Chatbot`) and a more maintainable design. It retains audio features and includes additional logic for generating responses to user queries.

### Key Features
- Plays a sound greeting (`sound greeting.wav`) on launch
- Displays an upgraded cybersecurity ASCII banner
- Uses a reusable `Chatbot` class to process user input
- Handles keyword-based queries with responses related to:
  - Password safety
  - Phishing
  - Safe browsing
- Recognizes multiple exit commands (`exit`, `bye`, `quit`)
- Loop-based interaction with user input and response

### Sample Inputs
- `Tell me about password safety`
- `What is phishing?`
- `How do I browse safely?`
- `bye`

---

## Requirements

- Visual Studio (Community Edition or higher)
- .NET 6.0 SDK or later
- Windows OS (for audio playback via `System.Media.SoundPlayer`)
- `.wav` files (`greeting.wav`, `sound greeting.wav`) placed in the output directory

### Audio File Setup

For both projects, ensure that your audio files are:
- Included in the project files
- Properties set to:
  - **Build Action**: Content
  - **Copy to Output Directory**: Copy if newer

---

## How to Run

1. Open the solution in **Visual Studio**.
2. Set either `poepart1` or `CybersecurityChatbot` as the startup project.
3. Press `F5` to build and run.
4. Interact via the console and type `exit` or `quit` to close.

---

## Future Improvements

- Add more topics (e.g., social engineering, ransomware, VPNs)
- Implement natural language processing for better input understanding
- Log user questions and chatbot responses for analytics
- Add a GUI interface for improved user experience

---

## Author

This project was created to support learning and awareness in cybersecurity topics using simple and interactive programming techniques.

