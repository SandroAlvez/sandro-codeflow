# sandro-codeflow

# About

This is a repository destined to practice E2E test automation with C# and Selenium. The project being tested is the website "opensourcedesign.net".

# Prerequisites

Stacks needed to execute the tests:

- Microsoft.NET.Test.Sdk 17.8.0
- MSTest.TestAdapter 3.1.1
- MSTest.TestFramework 3.1.1
- coverlet.collector 6.0.0
- Selenium.WebDriver 4.50.0
- Selenium.WebDriver.ChromeDriver 155.0.8059.3900

# Project Structure

The project developed with a "Page Object Model"  orientation. For each page of the website was created a class with their objects and methods. 

Also, each one has a class of tests, were the scenarios were designed to meet the requirements of the functionalities for each page.