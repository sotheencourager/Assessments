This is basic API test with C# get and post card data.

Steps to Run

- Verify that all Nuget packages for the solution are installed
- Build and Open Test Explorer - project = HPTestAPI and class = DeckOfCardTest
- Each test has standard output in the Test Detail Summary pane to show additional test status

Nuget PACKAGES

- NUnit
- RestSharp
- Newtonsoft.Json
- MSTest.TestAdapter

Project Setup
- Solution contains two projects to achieve some page object and code reusablility
- Assessment contains the data transfer objects and the test functions
- HPTestAPI contains the tests