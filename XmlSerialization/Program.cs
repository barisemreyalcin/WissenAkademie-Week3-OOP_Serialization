// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XmlSerialization;

List<Person> employeeList = new List<Person>()
{
    new Person()
    {
        PersonId = 1,
        FirstName = "John",
        LastName = "Wick",
        Email ="johnwick@contoso.com",
        Phone = "0000000000",
    },
    new Person()
    {
        PersonId = 2,
        FirstName = "Thomas",
        LastName = "Shelby",
        Email ="tommyshelby@contoso.com",
        Phone = "1111111111",
    },
    new Person()
    {
        PersonId = 3,
        FirstName = "Ada",
        LastName = "Shelby",
        Email ="adashelby@contoso.com",
        Phone = "2222222222",
    },
};

string xmlData = SerializeXml(employeeList);
//Console.WriteLine(xmlData);
Deserialize(xmlData);

void Deserialize(string xmlData)
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>)); // tipini söyledim
    StringReader strReader = new StringReader(xmlData); // xmlData'yı stringReader'a yükledim
    XmlReader xmlReader = new XmlTextReader(strReader); // string datayı da xmlReader'a yükledim
    List<Person> employeeList = (List<Person>)serializer.Deserialize(xmlReader); // sonra listeye unbox etmesini söyledim
    WriteEmployees(employeeList);
}

void WriteEmployees(List<Person>? employeeList)
{
    StringBuilder strPerson = new StringBuilder();
    foreach (Person employee in employeeList)
    {
        strPerson.Append(
            $"Person Id: {employee.PersonId}\n" +
            $"Full Name: {employee.FirstName} {employee.LastName}\n" +
            $"Email: {employee.Email}\n" +
            $"Phone: {employee.Phone}\n" +
            $"{new string('*', 75)}\n"
        );
    }
    Console.WriteLine(strPerson.ToString());
}

string SerializeXml(List<Person> employeeList)
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    TextWriter xmlWrite = new StringWriter(); // StringWriter TextWriter'dan türediği için böyle bir şey yapabilirim (bellekte çalışıyor)
    serializer.Serialize(xmlWrite, employeeList); // Text writer ve neyi serialize edeceğini parametre olarak bekliyor
    return xmlWrite.ToString();
}
