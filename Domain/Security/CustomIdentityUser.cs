﻿using Microsoft.AspNetCore.Identity;

namespace Domain.Security;

public class CustomIdentityUser : IdentityUser
{
    public FullName FullName { get; set; } = default!;
}
