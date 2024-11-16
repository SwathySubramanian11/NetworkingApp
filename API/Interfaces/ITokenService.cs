using System;
using API.Models;

namespace API.DTO;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
