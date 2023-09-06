using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningManagementSystemProject.ViewModel
{
    public class RoleViewModel
    {

        [System.ComponentModel.DataAnnotations.Required]
        public string RoleName { get; set; }
    }
}
