# First time login to Nexus
Login with user
username: admin
password: {default_password}
Default password stored in /nexus-data/admin.password

# Login to Nexus with admin user
Login with user
username: admin
password: {changed_password}

# Enable "NuGet API-Key Realm"
Go to Server administration and configuration -> Security
Move "NuGet API-Key Realm" to Active and Save

# Get API-Key
Go to Admin -> NuGet API Key -> Access API Key
Enter admin's password

# Allow Anonymous Access
Go to Server administration and configuration -> Anonymous Access
Enable "Allow anonymous users to access the server"

# Publish package to Nexus repository
> dotnet nuget push Com.Sample.Extensions.1.0.0.nupkg -k {NexusApiKey} -s {NexusRepositoryURL}

# Example for publish package to Nexus repository
> dotnet nuget push Com.Sample.Extensions.1.0.0.nupkg -k 82d3aabf-2ee4-34d7-8947-bb4876570931 -s http://localhost:8082/repository/nuget-hosted/