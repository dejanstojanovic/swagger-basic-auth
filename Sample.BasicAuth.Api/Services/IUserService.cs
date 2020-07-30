using System;
namespace Sample.BasicAuth.Api.Services
{
    public interface IUserService
    {
        bool ValidateCredentials(String username, String password);
    }
}
