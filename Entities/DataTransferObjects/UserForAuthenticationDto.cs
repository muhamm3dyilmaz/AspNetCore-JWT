using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "Username Required Field.")]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Password Required Field.")]
        public string? Password { get; init; }
    }
}
