﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookKeeper.BookingSystem.Accounts.ActiveAccounts
{
    public class ActiveAccount : Account
    {
        public ActiveAccount(string name, Account parent)
            :base(name, parent)
        {

        }
    }
}
