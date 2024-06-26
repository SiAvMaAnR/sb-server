﻿using System.ComponentModel.DataAnnotations;
using MessengerX.Domain.Shared.Constants.Validation;

namespace MessengerX.WebApi.Controllers.Models.User;

public class UserControllerUpdateInfoRequest
{
    [MaxLength(MaxLength.Login)]
    public required string Login { get; set; }
    public DateOnly? Birthday { get; set; }
}
