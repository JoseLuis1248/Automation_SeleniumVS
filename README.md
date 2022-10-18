![Image](/Resources/ProjectLogo.png)

# Automation_SeleniumVS

This is a free Automation Test Project that will allow you to start you career as an QA Automation Tester, since the most simple website until the most modern web application.

With this project you will be able to use a flexible architecture based on Page Object Model and Specflow, which allow you to write understandable automated test cases for each stakeholder of your company. Finally, thanks to Selenium Web driver, you can start easily creating automated test cases oriented to Acceptance Testing, Function Testing, Regressions and more..

## Features

- POM (Page object model): Structure for automation testing, where each page of your web application will have a class into the project.
- Selenium Web Driver: Powerfull tool that will allow you to handle multiple events on differents browsers.
- Specflow: BDD Framework for .NET development, useful to create test scenarios and improve the collaborations between parts.
- Gherkin: Powerfull language to write understandable test cases for all of your company.
- C#: One of the most useful programming languages
- Livind Doc: Easily and elegant reports to share with stakeholders of your company. Sharing your test cases and results has never been so easy.
- Nunit: Framework open source for .NET

## Getting Started with the project

To start your automated test cases development:
- Download or clone the project
- Open the project on Visual Studio
- Download the extension "Specflow for Visual Studio"
- Compile the solution

You are ready to start executing the test cases already done as examples, or just modify the code to adapt it to your projects or your company.
The test cases automated have been done to test some features of Google home page.

## Architecture
![Image](/Resources/Architecture.png)

- The features files will contain the description of all the test cases that will be automated. The point here is that you will be able to write them on Gherkin language, that will help everyone of the stakeholders to understand what is being automated; because Gherkin language is similar to the common language humans talk.
So, the point here is just to write the test cases in steps, on the most understandable way as possible, trying to make every step of the test cases as simple as you can.
If you need more information about it, you can find it on Specflow official website, on this link: https://specflow.org/learn/gherkin/
- On the other hand, we have the step-definition file. Each test case design (on the feature file) will use multiple functions on the step definition file. This one  will contain all the functions/scripts that will execute each step. So here, you have to understand that each step defined on the feature file will use one function on the step definition file. Sometimes, you can have one function for multiple steps, if you want to learn more, read more about here: https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step6.html
- Then we have the POM files, which are the Page classes and each one will have differents types of elements. Here, i have consider to make a class for each element to reutilize code.
- Finally, each function will use differents types of drivers to handle many browser where the test can be run. For this feature, i have considered just using Nuget packages that import each driver automatically, such as Chromedriver or Geckodriver, into the debug folder, so it is not neccesary to download each one manually.

## Management of projects

![Image](/Resources/Projects.png)

With the last picture, i want you to understand which will be your system to use this project to automate:
- All the future test projects will use "Main" project, because this one will contain all the POM structure: the page classes, the elements, the XML reader and others. So this project will not contain any test case, is just a project which its purpose is to have all the common functions in only one place. So if you have to modify something related with architecture, you will go there to modify it, and all the projects will use the functions updated.

## Elements coordination flow

![Image](/Resources/Examples.png)

These are some examples about flow that you will be using to automate new test cases on new projects.
- For example if you want to inicialize the browser, you will have to use the Browser class, which will use the XMLreader to now which driver has to instantiate and for that, it will use the configuration file, which one will have a line specifying the browser to execute.
- Another example, if you have to click on some page element, you have to use the page class, which will have lot of elements, select the element you want and select the method you want to execute.
- Finally, if you want to extract data of your XML file on your project, you have to use the XMLreader class and it will use the xml element on your project. 

## Living Doc

![Image](/Resources/LivingCodeExample.png)

This is a feature useful to generate reports for stakeholders. A really easy and elegant way to report test cases with or without test results.
The steps to generate the HTML report:
- Go to "Debug" folder of your project
- Open a CMD command prompt
- Enter the following code:
(without test results)
> livingdoc test-assembly (project name).dll
 - Enter the following code:
(with test results)
> livingdoc test-assembly (project name).dll -t TestExecution.json
- Share the HTML report created on the same folder

This is an example of how the HTML report looks:
https://joseluis1248.github.io/#/document/Standalone

Anyway, if you have question about more detailed features of Living Documentacion, you will be able to find it on Specflow official website.

## Crossbrowser Testing

![Gif](/Resources/CrossBrowser.gif)

I recommend to use Selenium Grid or another formal tool for CrossBrowser Testing. But, if you just want to execute your test cases on differents types of browser: on the proyect you will find a cross browser test example, which has been designed to be executed on Chrome, Firefox and Edge browsers.

## Credits

This project has been done using POM structure for automated test cases development, Specflow features and some common practices for projects.
There are a lot of information about POM (page object model) structure on internet and if you want to learn more about Specflow, there are some really good explanation videos about features files and step definition files on Specflow official channel on youtube. 
