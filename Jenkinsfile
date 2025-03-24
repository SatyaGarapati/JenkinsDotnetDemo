pipeline {
	agent any
	
	environment{
		DOTNET_ROOT = "/usr/lib64/dotnet"
		PATH = "$DOTNET_ROOT:$PATH"
	}
	
	stages {
		stage('Checkout'){
			steps{
				git branch: 'main',url: 'https://github.com/SatyaGarapati/JenkinsDotnetDemo.git'
			}
		}
		stage('Restore Dependencies'){
			steps{
				sh 'dotnet restore'
			}
		}
		stage('Build'){
			steps{
				sh 'dotnet build --configuration Release'
			}
		}
		stage('Publish') {
            steps {
                sh 'dotnet publish -c Release -o publish_output'
            }
        }
	}
	post {
        always {
            echo 'Build Completed'
        }
    }
}