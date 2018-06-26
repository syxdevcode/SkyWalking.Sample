FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
#拷贝当前文件夹下的文件到容器中系统的工作空间
COPY . /app
EXPOSE 80

ENTRYPOINT ["dotnet", "SkyWalking.Sample.Frontend.dll"]
