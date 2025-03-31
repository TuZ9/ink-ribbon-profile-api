namespace ink_ribbon_profile_api.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task Insert();
        Task Delete();
        Task Update();
        Task Get();
    }
}
