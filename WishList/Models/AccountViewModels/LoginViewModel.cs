﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class LoginViewModel
    {

       
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    

    }
}
