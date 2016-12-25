﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Globals
{
    public static class Defaults
    {
        public static string DateTimeFormat = "F";
        public static bool ShowEmailColumn = true;
        public static bool ShowUsernameColumn = true;
        public static bool ShowPasswordColumn = true;
        
        public static bool AllowLowercaseCharacters = true,
            AllowUppercaseCharacters = true,
            AllowNumberCharacters = true,
            AllowSpecialCharacters = true,
            AllowUnderscoreCharacters = false,
            AllowSpaceCharacters = false,
            AllowOtherCharacters = false;

        public static bool RequireLowercaseCharacters = true,
            RequireUppercaseCharacters = true,
            RequireNumberCharacters = true,
            RequireSpecialCharacters = true,
            RequireUnderscoreCharacters = false,
            RequireSpaceCharacters = false,
            RequireOtherCharacters = false;

        // Pick the number of characters.
        public static int MinimumCharacters = 10, MaximumCharacters = 12;

    }
}