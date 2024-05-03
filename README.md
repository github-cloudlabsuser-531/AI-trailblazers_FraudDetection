# AItrailblazersFraudDetect
Leverage Azure OPEN AI service to prevent fraud detection system in banking sector.

USE CASE 1:
A1)Steps to execute code in Visual Studio Code:
   
	1) Unzip the folder and open the workspace in Visual Studio Code.
	2) Go to Tools -> Command Line -> Developer PowerShell
	3) PromptShell will open with path -> ..\AI-trailblazers_FraudDetection\DebtTrap
	4) Type the below command in PowerShell
	   4.1) cd DebtTrap
	   4.2) dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.14
	   4.3) dotnet run
	   4.4) Enter the Question
	     Request - You are a loan approver agent and provide only definitive answers and considers factors, data which is given to you. Compare User A aggregate monthly income vs yearly income, analyze whether User A is eligible for loan of Rs 1500000 and provide the status as Loan Application: ?APPROVED or REJECTED
		 Response - "you will get response"
	   4.5) dotnet run
	   4.6) Enter the Question
		 Request - You are a loan approver agent and provide only definitive answers and considers factors, data which is given to you. Compare User B aggregate monthly income vs yearly income, analyze whether User B is eligible for loan of Rs 500000 and provide the status as Loan Application: ?APPROVED or REJECTED
		 Response - "you will get response"

B1)Steps to execute code in Azure Portal -> Cloud Shell:
		
		1) Once the terminal starts, enter the following command to download the sample application and save it to a folder called azure-openai
		  1.1) rm -r azure-openai -f
		  1.2) git clone https://github.com/github-cloudlabsuser-535/AI-trailblazers_FraudDetection.git azure-openai
		  1.3) cd azure-openai/DebtTrap/DebtTrap
		  1.4) code .
		  1.5) dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.14
		  1.6) dotnet run
		  1.7) Enter the Question
				Request - You are a loan approver agent and provide only definitive answers and considers factors, data which is given to you. Compare User A aggregate monthly income vs yearly income, analyze whether User A is eligible for loan of Rs 1500000 and provide the status as Loan Application: ?APPROVED or REJECTED
				Response - "you will get response"
	      1.8) dotnet run
	      1.9) Enter the Question
				Request - You are a loan approver agent and provide only definitive answers and considers factors, data which is given to you. Compare User B aggregate monthly income vs yearly income, analyze whether User B is eligible for loan of Rs 500000 and provide the status as Loan Application: ?APPROVED or REJECTED
				Response - "you will get response" 

USE CASE 2:
A2)Steps to execute code in Visual Studio Code:
   
	1) Unzip the folder and open the workspace in Visual Studio Code.
	2) Go to Tools -> Command Line -> Developer PowerShell
	3) PromptShell will open with path -> ..\AI-trailblazers_FraudDetection\IdentityMispresentation
	4) Type the below command in PowerShell
	   4.1) cd IdentityMispresentation
	   4.2) dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.14
	   4.3) dotnet run
	   4.4) Enter the Question
	     Request - You are loan approver agent and provide only definitive answers and considers factors, data which is given to you only. Compare for SAM identity data (PAN) in bank and income statement and provide    status as KYC :  ?FAILED or PASSED
		 Response - "you will get response"
	   4.5) dotnet run
	   4.6) Enter the Question
		 Request - You are loan approver agent and provide only definitive answers and considers factors, data which is given to you only. Compare for BEN identity data (PAN) in bank and income statement and provide    status as KYC :  ?FAILED or PASSED
		 Response - "you will get response"

B2)Steps to execute code in Azure Portal -> Cloud Shell:
		
		1) Once the terminal starts, enter the following command to download the sample application and save it to a folder called azure-openai
		  1.1) rm -r azure-openai -f
		  1.2) git clone https://github.com/github-cloudlabsuser-535/AI-trailblazers_FraudDetection.git azure-openai
		  1.3) cd azure-openai/IdentityMispresentation/IdentityMispresentation
		  1.4) code .
		  1.5) dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.14
		  1.6) dotnet run
		  1.7) Enter the Question
				Request - You are loan approver agent and provide only definitive answers and considers factors, data which is given to you only. Compare for SAM identity data (PAN) in bank and income statement and provide    status as KYC :  ?FAILED or PASSED
				Response - "you will get response"
		  1.8) dotnet run
		  1.9) Enter the Question
				Request - You are loan approver agent and provide only definitive answers and considers factors, data which is given to you only. Compare for BEN identity data (PAN) in bank and income statement and provide    status as KYC :  ?FAILED or PASSED
				Response - "you will get response"
