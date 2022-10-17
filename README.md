# Automation_SeleniumVS

The idea of this project is to share a basic Automation Project for everyone who wants to start creating automated test cases for Web applications using Selenium WebDriver and a flexible structure based on C# as a programming language and Visual Studio development tool.
This project has been made using Specflow and the architecture is based on Page Object Model with a little variation.

## Architecture
![Image](/Images/Architecture.png)
Meaning:
- The features files will contain the description of all the test cases that will be automated. The point here is that you will be able to write them on Gherkin language, that will help everyone of the stakeholders to understand what is being automated because Gherkin language is similar to the common language humans talk.
So, the point here is just to write the test cases in steps, on the most understandable way as possible, trying to make every step of the test cases as simple as you can.
If you need more information about it, you can find it on Specflow official website, on this link: https://specflow.org/learn/gherkin/
- On the other hand, we have the step-definition file. Each test case design (on the feature file) will use multiple functions on the step definition file. This one  will contain all the functions/scripts that will execute each step. So here, you have to understand that each step defined on the feature file will use one function on the step definition file. Sometimes, you can have one function for multiple steps, if you want to learn more, read more about here: https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step6.html?
- Then we have the POM files, which are the Page classes and each one will have differente types of elements. Here, i have consider to make a class for each element to reutilize code.
- Finally, each function will use differents types of drivers to handle many browser where the test can be run. For this feature, i have considered just using Nuget packages that import each driver automatically, such as Chromedriver or Geckodriver, into the debug folder, so it is not neccesary to download each one manually.
![Image](/Images/Projects.png)

## Living Doc
This is a feature from Specflow useful to generate reports for each stakeholder of the project. A really easy and elegant way to report test cases with or without test results.
The steps to generate the HTML report:
- Go to "Debug" folder of your project
- Open a CMD command prompt
- Enter the following code:
(without test results)
> livingdoc test-assembly (project name).dll
 - Enter the following code:
(with test results)
> livingdoc test-assembly (project name).dll -t TestExecution.json

Anyway, if you have question about more detailed features of Living Documentacion, you will be able to find it on Specflow official website.
![Image](/Images/LivingCodeExample.png)
 
