# Journal 5

### Attendance: Nicolas Dupuis, Anna Han, Troy Livingston
### Date: February 18, 21, 2021

-  select an appropriate testing framework
    - file - add - new project - NUnit 3 Test project : WarehouseManagementTests => .NET support NUnit test
    - right-clicking on References or Dependencies and then choosing Add Reference our project
    - add code to the unit test method
    - run unit tests: choose Test > Test Explorer > run all : green check mark indicates that a test passed
    - commandline for testing: dotnet test

-  write a few simple tests to ensure everything is installed correctly and working: Our team used Hello world class and make the test for simple string.

-  You should add all of your tests into tests directory: I made the test project in the src directory, so Nicolas move this packet to test directory. Troy checked about exit 0 for test.sh file.
 
 ### **My task for this week:**

 - [x] Understand GitHub Actions: CI(Continuous Integration:code, build, test), CD(Continuous Delivery/Deployment)
        - different between workflows and actions(actions belong to workflows)
        - workflow -> job -> step -> action

 - [x] status badge: Actions -> create status badge -> copy markdown -> paste in README

 - [x] understand 1) build matrix for each version, 2)how can separate build and test in jobs


 ### **Check our "Tasks"**

 - [x] The test.sh script is complete and exits with a return value of 0 when all tests pass and a non-zero value otherwise

 - [x] Create a few simple tests for your selected language and framework in the tests directory

 - [x] Delete the file named TODO-test-lab once you are done to mark this task complete!