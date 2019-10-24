FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
				

COPY ConceiseDinning.API/bin/Release/netcoreapp2.2/publish/ /app/

WORKDIR /app/

EXPOSE 80

CMD ["dotnet", "ConceiseDinning.API.dll"]
#demo2
