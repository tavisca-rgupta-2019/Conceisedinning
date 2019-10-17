pipeline {
    agent any
    parameters {
		string(name: 'Test_Project_Path', defaultValue: 'ConceiseDinning.API.Tests/ConceiseDinning.API.Tests.csproj')
		string(name: 'Project_Path', defaultValue: 'ConceiseDinning2.0.sln')
		string(name: 'Solution_Name', defaultValue: 'ConceiseDinning.API')
		
		
  }
 
    stages {
        stage('Build') {
            steps {
                bat '''
				dotnet build %Project_Path% -p:Configuration=release -v:q	
				dotnet test %Test_Project_Path%
				dotnet publish %Project_Path% -c Release -o ../publish
				
				
				
				'''
			}
			}
				
		
    }
}
