﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Tess.Shared.ViewModels
{
    public class InviteViewModel
    {
        public string ID { get; set; }
        public bool IsAdmin { get; set; }
        public DateTimeOffset DateSent { get; set; }
        [EmailAddress]
        public string InvitedUser { get; set; }
    }
}
