param(
[Parameter(Mandatory=$true)]
[string]$stackName
)
aws cloudformation deploy --template-file .\deploy.yaml --capabilities CAPABILITY_IAM --stack-name $stackName
