# Leap Year Evaluator

Leap year evaluator that loops through every year from 1 to now, and determines if it's a leap year or not.
The program will output two files, one in CSV format and one in JSON format.

## Project Setup

> Before setting up the project, you will first need to install Visual Studio 2022 (or another IDE) and .Net 8, which can be downloaded [here](https://visualstudio.microsoft.com/downloads/).

Click the green "Code" button on the top of the [repository page](https://github.com/DanRLBailey/LeapYearEvaluator), then copy the repo link.

![Image of the clone link copy](https://github.com/DanRLBailey/LeapYearEvaluator/assets/41433945/316cf856-b112-40df-8804-d3f719ff8869)

On your local machine, navigate to a folder that you would like to clone the repo into
Click into the address bar, type "cmd" then hit enter.

![Image of the file explorer, with CMD in the address bar](https://github.com/DanRLBailey/LeapYearEvaluator/assets/41433945/ae0e7377-ec35-4b59-9ba4-592cc4704d5f)

Enter the following command, then hit enter and wait for the repo to clone:

```
git clone https://github.com/DanRLBailey/LeapYearEvaluator
```

## Running the Program

Open the folder that was just created in the clone, and double click on `LeapYearEvaluator.sln`, this will open the program in Visual Studio.

![Image of the file explorer, with LeapYearEvaluator highlighted](https://github.com/DanRLBailey/LeapYearEvaluator/assets/41433945/2ed1cf19-b7e4-43a5-86af-91d09352976c)



Once opened, press "F5" or press the green "Play" button in the toolbar at the top. This will open a command prompt dialogue box, which displays the total number of leap years that have happened since year 1. Pressing any button at this point will close the command prompt window.

![Image showing the green plus button, and the total number of leap years](https://github.com/DanRLBailey/LeapYearEvaluator/assets/41433945/efe96fbf-4207-4d40-bd3e-291078c42b3c)



## File Outputs

After the program has been run, two new files will have been automatically created in the following folder:

> [Repository location] / LeapYearEvaluator / bin / Debug / net8.0

These are the CSV and JSON outputs of the program, named `output.csv` and `output.json` respectively.

Open the CSV file in a text editor and you will see a list of all the years, from 1 to now, and a "Yes" or "No" depending on if it's a leap year or not:

![Image showing the CSV output in a text editor](https://github.com/DanRLBailey/LeapYearEvaluator/assets/41433945/7bec4e97-685b-46cb-b2d2-56e5cc3d9e63)


Opening the same CSV file in a spreadsheet viewer (Excel, Google Sheets, etc) or csv formatter will show the same data, but formatted in a nicer way:

![Image showing the CSV output in a formatted table](https://github.com/DanRLBailey/LeapYearEvaluator/assets/41433945/ac911b42-6b0d-4dfd-bc52-02d241341011)


Open the JSON file in a text editor and you will see an array of objects, showing all the years, from 1 to now, and a "Yes" or "No" depending on if it's a leap year or not.

![Image showing the JSON output in a formatted array](https://github.com/DanRLBailey/LeapYearEvaluator/assets/41433945/74b29c73-865f-48d0-92a6-03b6105e83b7)

