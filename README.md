# sandro-codeflow

# About

This is an E2E test automation project that aims to serve as a test suite for the following opensource project: "opensourcedesign.net". It was developed using Selenium Webdriver with C#.

# Prerequisites

Stacks needed to execute the tests:

- .NET 10
- Microsoft.NET.Test.Sdk 17.8.0
- MSTest.TestAdapter 3.1.1
- MSTest.TestFramework 3.1.1
- coverlet.collector 6.0.0
- Selenium.WebDriver 4.50.0
- Selenium.WebDriver.ChromeDriver 155.0.8059.3900

# Project Structure

The project is developed with a "Page Object Model"  orientation. For each page of the website, it was created a class with their objects and methods. 

Also, each page has a test class, were the scenarios were designed to meet the requirements of the functionalities for their respctive page.

To offer some flexibility, tests were divided into two test suites: "Full Suite" and "Smoke Test".

The "Full Suite" represents all tests, and will execute them all.

The "Smoke Test" will execute only the tests that cover the most important functionalities and business-relevant tests.