// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region DataContractJsonSerializer JSON Format
//using System.Runtime.Serialization.Json;
//using System.Text;
//using JsonSerialization;

//Article article = new Article()
//{
//    ArticleId = 1,
//    ArticleName = "101: C# OOP",
//    ArticleDescription = "C# Applications with Object-Oriented Programming",
//    ArticleSiteList = new List<string>() { "www.medium.com", "www.codeproject.com", "www.csharp.com" }
//};

//string jsonData = string.Empty;
//SerializeArticle(article, ref jsonData);
////Console.WriteLine(jsonData);
//DeserializeData(jsonData);

//void DeserializeData(string jsonData)
//{
//    using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonData))) // json datayı bite dizisine çevirecem
//    {
//        DataContractJsonSerializer jsonDeserializer = new DataContractJsonSerializer(typeof(Article));
//        Article article = (Article)jsonDeserializer.ReadObject(ms); // Object dönüyor ve Article'a cast ediyorum
//        //Article article = jsonDeserializer.ReadObject(ms) as Article; 
//        string articleInfo = string.Empty;
//        WriteArticle(article, ref articleInfo);
//        Console.WriteLine(articleInfo);
//    };
//}

//void WriteArticle(Article? article, ref string articleInfo)
//{
//    StringBuilder stringBuilder = new StringBuilder();
//    stringBuilder.Append($"Article ID: {article.ArticleId}\n");
//    stringBuilder.Append($"Article Name: {article.ArticleName}\n");
//    stringBuilder.Append($"Article Description: {article.ArticleDescription}\n");
//    stringBuilder.Append($"Article Sites: {string.Join(',', article.ArticleSiteList)}");
//    articleInfo = stringBuilder.ToString();
//}

//void SerializeArticle(Article article, ref string jsonData)
//{
//    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Article)); // ne tip data serialize edecek söylüyoruz
//    MemoryStream articleStream = new MemoryStream(); // memory'e yazıyorum
//    jsonSerializer.WriteObject(articleStream, article);
//    articleStream.Position = 0; // binary çalışır arkada

//    StreamReader strReader = new StreamReader(articleStream); // belleğe yazdığım datayı okuyorum
//    string json = strReader.ReadToEnd();
//    jsonData = json;
//}
#endregion

#region JsonSerializer JSON Format
using System.Reflection.Metadata;
using System.Text.Json;
using JsonSerialization;

List<User> userList = new List<User>()
{
    new User()
    {
        UserId = 1,
        Username = "jaxteller",
        Password = "123456",
        IsLoggedIn = true,
        LoginInfo = new List<LoginInformation>()
        {
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-4),
                LoginState = true,
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-3),
                LoginState = true,
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-2),
                LoginState = false,
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-4),
                LoginState = false,
            }
        }
    },
    new User()
    {
        UserId = 2,
        Username = "johnteller",
        Password = "654321",
        IsLoggedIn = true,
        LoginInfo = new List<LoginInformation>()
        {
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-4),
                LoginState = false,
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-3),
                LoginState = true,
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-2),
                LoginState = true,
            },
            new LoginInformation()
            {
                LoginTime = DateTime.Now.AddDays(-4),
                LoginState = false,
            }
        }
    }
};

var options = new JsonSerializerOptions
{
    WriteIndented = true,
};

string jsonData = JsonSerializer.Serialize(userList, options);
//Console.WriteLine(jsonData);

List<User> users = JsonSerializer.Deserialize<List<User>>(jsonData);
WriteUsers(users);
void WriteUsers(List<User>? users)
{
    if (users.Count == 0)
    {
        Console.WriteLine("User list is empty");
    }
    else
    {
        foreach (User user in users) {
            Console.WriteLine($"User id: {user.UserId}");
            Console.WriteLine($"Username: {user.Username}");
            Console.WriteLine($"User password: {user.Password}");
            Console.WriteLine($"User logged in: {user.IsLoggedIn}");
            Console.WriteLine(new string('x', 100));
        }
    }
}
#endregion