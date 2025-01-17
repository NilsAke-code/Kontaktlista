using Business.Interfaces;


namespace Business.Helpers;


public class IdGenerator : IIdGenerator
{
    public Guid GenerateId()
    { 

    return Guid.NewGuid(); 

    }
}
