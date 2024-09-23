// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using BinarySerialization;

List<Member> memberList = new List<Member>();

Member member = new Member()
{
    MemberId = Guid.NewGuid(),
    FirstName = "Jax",
    LastName = "Teller",
    Age = 30,
};

Member member1 = new Member()
{
    MemberId = Guid.NewGuid(),
    FirstName = "Tony",
    LastName = "Soprano",
    Age = 44,
};

Member member2 = new Member()
{
    MemberId = Guid.NewGuid(),
    FirstName = "Thomas",
    LastName = "Shelby",
    Age = 34,
};

memberList.AddRange(new Member[] { member, member1, member2 });

//Serialize(member); // member yazdım
SerializeList(memberList);

//Deserialize();
DeserializeList();

void DeserializeList()
{
    using (FileStream fs = new FileStream("members.txt", FileMode.Open, FileAccess.Read))
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        List<Member> memberList = (List<Member>)binaryFormatter.Deserialize(fs);
        foreach (Member member in memberList)
        {
            Console.WriteLine(member.ToString());
            Console.WriteLine(new string('-', 50));
        }
    }
}

void Deserialize()
{
    using (FileStream fs = new FileStream("members.txt", FileMode.Open, FileAccess.Read))
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        //binaryFormatter.Deserialize(fs); // member okumam gerek (bu object dönüyor --> unboxing)
        Member member = (Member)binaryFormatter.Deserialize(fs);
        //WriteMember(member); // Bununla deserialize ettiğimiz data'yı tekrar app'imizde kullanmış oluyoruz
        Console.WriteLine(member.ToString()); ; // Bununla deserialize ettiğimiz data'yı tekrar app'imizde kullanmış oluyoruz

    }
}

//void WriteMember(Member member)
//{
//    StringBuilder strMember = new StringBuilder();
//    strMember.Append(
//        $"Member Id: {member.MemberId}\n" +
//        $"Member Full Name: {member.FirstName} {member.LastName}\n" +
//        $"Member Age: {member.Age}"
//    );
//    Console.WriteLine(strMember.ToString());
//}

void SerializeList(List<Member> memberList)
{
    FileStream fs = new FileStream("members.txt", FileMode.Create, FileAccess.Write);
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.Serialize(fs, memberList);
    fs.Close();
}

void Serialize(Member member)
{
    FileStream fs = new FileStream("members.txt", FileMode.Create, FileAccess.Write);
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.Serialize(fs, member);
    fs.Close();
}
