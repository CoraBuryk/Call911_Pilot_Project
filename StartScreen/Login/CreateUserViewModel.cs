using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartScreen.Login
{
    [Serializable]
    public class CreateUserViewModel
    {
        [Name]
        [MinLength(2, ErrorMessage = "Минимальная длина должна быть больше 2 символов")]
        [MaxLength(50, ErrorMessage = "Длина не должна превышать больше 50 символов")]
        public string Name { get; set; }

        [Password]
        public string Password { get; set; }
    }
}
