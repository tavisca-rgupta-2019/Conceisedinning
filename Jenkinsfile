pipeline {
    agent any
	parameters {
	       
	       string(name : 'SOLUTION_FILE_PATH', defaultValue: 'ConceiseDinning2.0.sln')
               string(name : 'TEST_PROJECT_PATH', defaultValue: 'ConceiseDinning.API.tests/ConceiseDinning.API.tests.csproj')
               string(name : 'PROJECT_FILE_PATH', defaultValue: 'ConceiseDinning.API/ConceiseDinning.API.csproj')
	       string(name : 'DOCKERHUB_USERNAME', defaultValue: 'rohit1998')
	       string(name : 'PROJECT_NAME', defaultValue: 'ConceiseDinning')
	       string(name : 'DOCKERHUB_PASSWORD', defaultValue: 'rohit1998password')
	       
            }
	stages {
		stage('Build') {

	
           
		
			steps {
				
		    powershell'''
				

				dotnet restore ${SOLUTION_FILE_PATH} --source https://api.nuget.org/v3/index.json
				dotnet build ${SOLUTION_FILE_PATH} -p:Configuration=release -v:n
                              '''
			 }
			}
             
               stage('Publish') {
	          steps {
		      powershell'''
			     
			     dotnet publish ${PROJECT_FILE_PATH} -p:Configuration=release -v:n
			    '''
                        }
               }
	    
	    stage('Preparing_Docker_Image') {
		     when {
                // Only say hello if a "greeting" is requested
                expression { env.BRANCH_NAME == 'DEV' }
            }
	    
		steps {
			
				
					     powershell "docker build --tag=rohit1998/conceirge-dinning-api ."
					     powershell "docker login --username=${DOCKERHUB_USERNAME} --password=${DOCKERHUB_PASSWORD}"
				             
					      
                                              powershell "docker push rohit1998/conceirge-dinning-api"
					      powershell"docker run -d -p 5000:80 rohit1998/conceirge-dinning-api"
			 
				
				
				
                               
			       
			}
	       }
	   }

	
	
}



