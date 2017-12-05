jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "LoginFeature.feature",
      "Feature": {
        "Name": "LoginFeature",
        "Description": "As a site user, I want to login to the site so that I can use its functionality",
        "FeatureElements": [
          {
            "Name": "User Checking the login",
            "Slug": "user-checking-the-login",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have navigated to the site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I goto login page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter following login details",
                "TableArgument": {
                  "HeaderRow": [
                    "UserName",
                    "Password"
                  ],
                  "DataRows": [
                    [
                      "Admin1",
                      "Password1"
                    ],
                    [
                      "Admin2",
                      "Password2"
                    ],
                    [
                      "Admin3",
                      "Password3"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I press login button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see application main page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@login"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    },
    {
      "RelativeFolder": "RegisterForm.feature",
      "Feature": {
        "Name": "RegisterForm",
        "Description": "As a site user, I want to login to the site so that I can use its functionality",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Initial",
                    "FirstName",
                    "LastName"
                  ],
                  "DataRows": [
                    [
                      "K",
                      "Hello",
                      "World"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Checking the Registeration Form With HelloWorld",
            "Slug": "checking-the-registeration-form-with-helloworld",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have navigated to the site",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter intial <Initial>, FirstName <FirstName> and LastName <LastName>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I press register button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see application main page",
                "StepComments": [],
                "AfterLastStepComments": [
                  {
                    "Text": "# @register"
                  },
                  {
                    "Text": "#Scenario Outline: Registeration Form with Jack"
                  },
                  {
                    "Text": "#\tGiven I have navigated to the site"
                  },
                  {
                    "Text": "#\tWhen I enter intial <Initial>, FirstName <FirstName> and LastName <LastName>"
                  },
                  {
                    "Text": "#\tWhen I press register button"
                  },
                  {
                    "Text": "#\tThen I should see application main page"
                  },
                  {
                    "Text": "#Examples:"
                  },
                  {
                    "Text": "#    \t| Initial | FirstName   | LastName |"
                  },
                  {
                    "Text": "#\t    | A       | Jack        |   Man  |"
                  }
                ]
              }
            ],
            "Tags": [
              "@register"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "RegisterJake.feature",
      "Feature": {
        "Name": "RegisterJake",
        "Description": "As a site user, I want to login to the site so that I can use its functionality",
        "FeatureElements": [],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@login",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@register",
        "Total": 1,
        "Passing": 0,
        "Failing": 1,
        "Inconclusive": 0
      }
    ],
    "Folders": [
      {
        "Folder": "LoginFeature.feature",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "RegisterForm.feature",
        "Total": 1,
        "Passing": 0,
        "Failing": 1,
        "Inconclusive": 0
      },
      {
        "Folder": "RegisterJake.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "LoginFeature.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "RegisterForm.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "RegisterJake.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 2,
      "Passing": 1,
      "Failing": 1,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 3,
      "Passing": 1,
      "Failing": 1,
      "Inconclusive": 1
    }
  },
  "Configuration": {
    "GeneratedOn": "4 December 2017 12:58:26"
  }
});