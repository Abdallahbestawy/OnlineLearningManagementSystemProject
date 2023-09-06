using Microsoft.AspNetCore.Identity;
using OnlineLearningManagementSystemProject.Models;
using System.Security.Claims;

namespace OnlineLearningManagementSystemProject.Services
{
    public interface IdentityRepository
    {
        string GetUserId(string userId);
    }
}
