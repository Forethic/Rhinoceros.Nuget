# Install script for code snippets with Nuget

# Required call to get environment variables
param($installPath, $toolsPath, $package, $project)

# You only have to customize the $snippetFolder name below, 
# don't forget to rename the $snippetFolder of the other file
# ("uninstall.ps1") as well

$snippetFolder = "Rhinoceros"

# Actual script start
$source = "$toolsPath\*.snippet"
$vsVersions = @("2017", "2019")
$myDocuments = [Environment]::GetFolderPath("MyDocuments")

Foreach ($vsVersion in $vsVersions)
{
	$myCodeSnippetsFolder = "$myDocuments\Visual Studio $vsVersion\Code Snippets\Visual C#\My Code Snippets\"
	
	if (Test-Path $myCodeSnippetsFolder)
	{
		$destination = "$myCodeSnippetsFolder$snippetFolder"
		if (!($myCodeSnippetsFolder -eq $destination))
		{
			if(!(Test-Path $destination))
			{
				New-Item $destination -itemType "directory"
			}

			"Installing code snippets for Visual Studio $vsVersion"
			Copy-Item $source $destination
		}
	}
	else
	{
		"Define a value for snippetFolder variable, cannot be empty"
	}
}