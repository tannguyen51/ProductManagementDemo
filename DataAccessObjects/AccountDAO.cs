﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public static AccountMember GetAccountById(string accountID)
    {
        AccountMember accountMember = new AccountMember();

        if (accountID.Equals("PS0001")) // just for demonstration
        {
            accountMember.MemberId = accountID;
            accountMember.MemberPassword = "@1";
            accountMember.MemberRole = 1;
        }

        return accountMember;
    }
}