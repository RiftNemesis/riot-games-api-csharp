# Riot Games API C#

![Incomplete](https://img.shields.io/badge/Incomplete-red)
[![C# 4.0](https://img.shields.io/badge/C%23-4.0-blue?logo=c-sharp)](https://github.com/topics/csharp)
[![.NET Framework 4.0](https://img.shields.io/badge/.NET%20Framework-4.0-blue?logo=dot-net)](https://github.com/topics/dotnet)
[![Plarform Windows](https://img.shields.io/badge/Windows-blue?logo=windows)](https://github.com/topics/windows)

Simple C# Library with a GUI console to access Riot Games API.

![screenshot](./screenshot.gif?raw=true "RiotGamesAPI GUI-Console")
![screenshot2](./screenshot2.gif?raw=true "RiotGamesAPI GUI-Console")

## 🚀 Development

The source is written in **[C#](https://github.com/dotnet/csharplang) 4.0** with **[.NET](https://github.com/dotnet) Framework 4.0** and **[WinForms](https://github.com/dotnet/winforms)** using **[Visual Studio](https://visualstudio.microsoft.com) 2010**.

## 🎨 Structure :

- :open_file_folder: **RiotGamesAPI**:
  - :page_facing_up: **ApiConnection**: Setups a connection to the API.
  - :page_facing_up: **ApiMethod**: Abstract class for using an API method.
  - :page_facing_up: **Utilities**: Usefull methodes for dealing with some types of data used.
  - :file_folder: **API**: Classes for using all api available API methods.
  - :file_folder: **DTO**: Classes for holding all kinds of JSON data objects returned by the API methods.

## 📝 How to use ?
Learn by a simpe example: Getting a summoner informations.<br/>
To get summoner data, we use the **SummonerV3** API.

1. Setup a connection to the API using your **API Key** and choosing a **region** :
```csharp
string apiKey = "RGAPI-xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
ApiConnection apiConnection = new apiConnection(apiKey, ApiConnection.RegionCode.euw1);
```
2. Setup an instance of **SummonerV3** using the created connection :
```csharp
SummonerV3 summonerApi = new SummonerV3(apiConnection);
```
3. Use the SummonerV3 API method **GetSummonerBySummonerName** to get a **SummonerDTO** object containing the retrieved data :
```csharp
SummonerDTO summonerData = summonerApi.GetSummonerBySummonerName(summonerName);
```
4. The retrieved summoner data can now be used through the SummonerDTO object :
```csharp
string message = "The level of this summoner is " + summonerData.SummonerLevel;
```
5. GG IZI :smile:

## :page_facing_up: License

This project is licensed under the [Apache License 2.0](./LICENSE?raw=true).

This project uses:

- [Json.NET](https://github.com/JamesNK/Newtonsoft.Json) licensed under the [MIT License](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md)

> Disclaimer: This project is not endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or anyone officially involved in producing or managing League of Legends. League of Legends and Riot Games are trademarks or registered trademarks of Riot Games, Inc. League of Legends © Riot Games, Inc.
