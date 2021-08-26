﻿using System;

namespace Day09.Global
{
    public static class Globals
    {
        private static readonly Guid _currentUser = Guid.NewGuid();
        //temporary solution
        public static Guid CurrentUser { get => _currentUser; }
    }
}
