FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
#������ǰ�ļ����µ��ļ���������ϵͳ�Ĺ����ռ�
COPY . /app
EXPOSE 80

ENTRYPOINT ["dotnet", "SkyWalking.Sample.Frontend.dll"]