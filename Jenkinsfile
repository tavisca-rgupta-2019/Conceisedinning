pipeline {
    agent any
    parameters {
		string(name: 'Test_Project_Path', defaultValue: 'ConceiseDinning.API.Tests/ConceiseDinning.API.Tests.csproj')
		string(name: 'Project_Path', defaultValue: 'ConceiseDinning2.0.sln')
		string(name: 'Solution_Name', defaultValue: 'ConceiseDinning.API')
		
		string(name: 'Listen_To_Port', defaultValue: '6000')
		string(name: 'Docker_Username', defaultValue: 'ichandan8')
		string(name: 'Docker_Password',defaultValue:'Firstcompany@799)
		string(name: 'Name_Of_Docker_Image',defaultValue:'webapidockerimage')
		string(name: 'Docker_Image_Version', defaultValue:'latest')
  }
 
    stages {
        stage('Build') {
            steps {
                bat '''
				dotnet build %Project_Path% -p:Configuration=release -v:q	
				dotnet test %Test_Project_Path%
				dotnet publish %Project_Path% -c Release -o ../publish
				
				docker build --tag=%Docker_Username%/%Name_Of_Docker_Image%:%Docker_Image_Version% --build-arg project_name=%Solution_Name%.dll .
				docker login -u %Docker_Username% -p %Docker_Password%				
				docker push %Docker_Username%/%Name_Of_Docker_Image%:%Docker_Image_Version%
				
				'''
			}
			}
				
		stage('Deploy') {
            steps {
                bat '''
				docker pull %Docker_Username%/%Name_Of_Docker_Image%:%Docker_Image_Version%
				
				echo "hit localhost:%Listen_To_Port%/chat"				
				
				docker run -p %Listen_To_Port%:80 %Docker_Username%/%Name_Of_Docker_Image%:%Docker_Image_Version%
				
				
				
				'''
            }
        }
    }
}
