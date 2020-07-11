using FTLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FTLibrary.DataAccess
{
    public interface IDataConnection
    {
        User CreateUser(User model);

    }
}
