namespace WebApi2.Models;
public class UserModel
{
    Guid Id { get; }
    String FirstsName { get; }
    String LastName { get; }
    int Age { get; }

    public UserModel(Guid id, string firstsName, string lastName, int age)
    {
        Id = id;
        FirstsName = firstsName;
        LastName = lastName;
        Age = age;
    }
}
