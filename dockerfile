FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
				

COPY ConceiseDinning.API/bin/Release/netcoreapp2.1/publish/ /app/

WORKDIR /app/

EXPOSE 5000

CMD ["dotnet", "ConceiseDinning.API.dll"]
