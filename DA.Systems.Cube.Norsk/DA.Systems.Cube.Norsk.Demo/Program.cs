// See https://aka.ms/new-console-template for more information

using DA.Systems.Cube.Norsk.Api;
using DA.Systems.Cube.Norsk.Client;

Configuration instance  = new() {
    BasePath = "https://dev-api.norsk-global.com",
    AccessKeyId = "MV63NWP47NOEZYBA",
    SecretAccessKey = "BKZ2HU4TIWIE2PYHKPOLO3QQXKIS2S5MP5YKJLBXO445P5VM"
};
GlobalConfiguration.Instance = instance;

TestApi api = new (instance);
var result = await api.GetApiTestAsync();
Console.WriteLine(result);