namespace SpecificationPattern.Ports
{
    public interface IRepository
    {
        bool UserNameAlreadyExists(string userName);
    }
}