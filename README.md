
# Practice - Travel Companion: Vacation Application

This project is a simple console-based C# application designed to assist users in estimating the cost of a 3-day vacation. Users can select from three vacation destinations, choose the number of people traveling, and select their mode of transportation to calculate the total estimated cost.

## Project Overview

The application provides the following functionalities:

1. **Destination Selection:**
   - Users can choose from three vacation destinations: Bodrum, Marmaris, and Çeşme.
   - The application ensures case-insensitivity and handles invalid inputs by prompting the user to re-enter a valid destination.

2. **Number of Travelers:**
   - Users are prompted to enter the number of people traveling.

3. **Travel Summary:**
   - The application displays a summary of the selected destination and what users can do there.

4. **Transportation Options:**
   - Users can choose between two modes of transportation: Road (1500 TL per person for round trip) and Air (4000 TL per person for round trip).
   - The application validates the input and prompts for re-selection if an invalid choice is made.

5. **Cost Calculation:**
   - The application calculates the total estimated cost based on the selected destination, number of travelers, and transportation mode.

6. **Repeat or Exit:**
   - After displaying the total cost, the application asks if the user wants to plan another vacation or exit.

### Example Output

**Destination Selection:**
```
Enter your desired destination (Bodrum, Marmaris, Çeşme):
```
- If the user enters an invalid destination, the application provides a reminder and asks for re-entry.

**Transportation Selection:**
```
Select transportation mode:
1 - Road (1500 TL per person round trip)
2 - Air (4000 TL per person round trip)
```
- The application validates the choice and re-prompts if an invalid option is selected.

**Cost Summary:**
```
Destination: Bodrum
Number of travelers: 3
Transportation: Road

Total estimated cost: 10500 TL
```

**Repeat or Exit:**
```
Would you like to plan another vacation? (yes/no)
```
- The application either restarts or exits based on user input.

## How to Run the Project

To run this project, follow these steps:

1. Install [Visual Studio](https://visualstudio.microsoft.com/) or another C# IDE.
2. Ensure you have [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.
3. Clone or download this repository to your local machine.
4. Open the project in Visual Studio by loading the `.sln` file or by opening the project folder.
5. Run the project using the shortcut `Ctrl + F5` or via the terminal command:
    ```bash
    dotnet run
    ```
6. Follow the on-screen instructions to select a destination, enter the number of travelers, choose transportation, and view the cost.

## Technologies Used

- **C#**: The programming language used to implement the application.
- **.NET Core**: The framework used to compile and run the application.
- **Visual Studio**: The integrated development environment (IDE) used for writing, building, and running the code.

## Features

- Destination and transportation selection with input validation.
- Dynamic cost calculation based on user input.
- Option to repeat the process or exit the application.

## Contribution

This project is intended for educational purposes and practice. Contributions are not necessary, but feedback and suggestions for improvement are welcome.

## License

This project is designed for educational purposes and does not require a specific license.

![image](https://github.com/user-attachments/assets/b1f04d03-1ba8-448d-9fa2-eedf127b563d)
