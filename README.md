# Automation_SeleniumVS

On this project, the idea is to shared a basic Automation Project for everyone who wants to start creating automated test cases for Web applications using Selenium WebDriver and a flexible structure based on C# as a programming language and Visual Studio development tool.
This project has been made using Specflow and the architecture is based on Page Object Model with a little variation.

Architecture
![Image]{Images/Architecture.png}

Living Doc
This is a feature from Specflow useful to generate reports for each stakeholder of the project. A really easy and elegant way to report test cases with or without test results.
The steps to generate the HTML report:
1- Go to "Debug" folder of your project
2- Open a CMD command prompt
3- Enter the following code:
(without test results)
livingdoc test-assembly <project name>.dll
(with test results)
livingdoc test-assembly <project name>.dll -t TestExecution.json

Anyway, if you have question about more detailed features of Living Documentacion, you will be able to find it on Specflow official website.
