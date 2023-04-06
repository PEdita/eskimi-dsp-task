# Use an official Microsoft .NET Core SDK as a parent image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# Set the working directory to the location of your test project
WORKDIR /app/tests

# Copy the test project files to the container
COPY . /app/tests

# Restore NuGet packages
RUN dotnet restore

# Run the tests
CMD ["dotnet", "test"]

