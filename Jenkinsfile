pipeline {
	agent any
	
	environment{
		DOTNET_ROOT = "/usr/lib64/dotnet"
		PATH = "$DOTNET_ROOT:$PATH"
	}
	
	stages {
		stage('Checkout'){
			steps{
				git branch: 'main', 'https://github.com/SatyaGarapati/JenkinsDotnetDemo.git'
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
		stage('Test'){
			steps{
				sh 'dotnet test --no-build --verbosity normal || true'
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