// See https://aka.ms/new-console-template for more information

using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;
using Newtonsoft.Json;

const string apiKey = "E0F52BF9B87F4FB4942A5CFFD3AAFD16";
const string apiSecret = "yqKJDX8GTSeF3h6ZNW6Qwb9SaLNmXuZCtniZZSsPpLg=";

var config = new Configuration {
    Key = apiKey,
    Secret = apiSecret,
};
const string requestContent = """
                              {"ClientReference":"1ec867c3-bea6-46a3-8c40-7601c1779b79","MessageType":"sms","MessagePriority":"100","SenderId":"b2afc17b-ff7f-4982-80f4-36078a952aa7","CallbackUrl":null,"ScheduledDeliveryDate":"2024-04-13T02:00:00+02:00","Contacts":[{"DisplayName":"Test Contact 1","Title":null,"FirstName":"First Name 1","LastName":"Last Name 1","Email":"test1@gov.domain","MobileNo":"00263779960053","PreferredLanguage":"en"}],"MessageContent":[{"Language":"en","Subject":"Test Email Subject in English","MessageBody":"Email Body in English"},{"Language":"mt","Subject":"Test Suġġett bl-Malti","MessageBody":"Kontenut tal-email bil-Malti"}]}
                              """;

// var keysApi = new APIKeyApi(config);
// var keys = await keysApi.GetApiV1KeyAsync();
// Console.WriteLine(keys?.ToJson());

var payload = JsonConvert.DeserializeObject<CreateMessageRequest>(requestContent);
var messagesApi = new MessagesApi(config);
var inboundMessageBatch = await messagesApi.PostApiV1MessagesAsync(payload);
Console.WriteLine(inboundMessageBatch?.ToJson());