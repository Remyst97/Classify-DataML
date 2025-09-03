# Classify-DataML
This repository contains a C# console application that uses ML.NET to perform a classic data classification task: predicting the species of an iris flower based on its physical measurements.

Iris Species Classification with ML.NET

This repository contains a C# project that demonstrates multi-class data classification using the ML.NET framework. The project is a classic example of predicting the species of an iris flower based on its sepal and petal measurements.

Technologies

ML.NET: Microsoft's open-source and cross-platform machine learning framework.

C#: The core programming language for the console application.

Visual Studio: The Integrated Development Environment (IDE) used to develop the project.

Project Structure

ClassifyData.sln: The Visual Studio solution file that organizes the project.

ClassifyData.csproj: The C# project file that defines the project's structure and references.

Program.cs: The main entry point of the application where sample data is used for a prediction.

ModelInput.cs: A class defining the model's input data, such as sepallength and petalwidth.

ModelOutput.cs: A class defining the model's output, including the PredictedLabel (the iris species).

ConsumeModel.cs: Contains the methods for loading the pre-trained model and making predictions.

ModelBuilder.cs: (Optional for demonstration) Contains the code for building and training the model from scratch.

How to Run the Project

Prerequisites

Visual Studio: You will need Visual Studio with the .NET desktop development workload installed.

.NET SDK: This project targets a modern .NET SDK, so ensure you have a compatible version (e.g., .NET 8.0) installed.

Steps

  1. Clone the Repository: Clone this repository to your local machine using a Git client or by downloading the ZIP file.
```
git clone [https://github.com/YourUsername/ClassifyData.git](https://github.com/YourUsername/ClassifyData.git)
```
  2. Open in Visual Studio: Open the ClassifyData.sln file in Visual Studio.

  3. Restore NuGet Packages: Visual Studio should automatically restore the necessary NuGet packages. If not, right-click the solution in the Solution Explorer and select          Restore NuGet Packages.

  4. Run the Application: You can now run the console application by pressing F5 or by clicking the Start button in Visual Studio. The output will be displayed in the console window.
