﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace S7RTORRES
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
