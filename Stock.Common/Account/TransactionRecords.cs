﻿/*
 * This library is part of Stock Trader System
 *
 * Copyright (c) qiujoe (http://www.github.com/qiujoe)
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * For further information about StockTrader, please see the
 * project website: http://www.github.com/qiujoe/StockTrader
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Account
{
    public class TransactionRecord
    {
        public virtual int Id { get; set; }
        public virtual int StrategyId { get; set; }
        public virtual int EntrustNo { get; set; }
        public virtual string StockCode { get; set; }
        public virtual string StockName { get; set; }
        public virtual string OperType { get; set; }
        public virtual int Amount { get; set; }
        public virtual float Price { get; set; }
        public virtual float Turnover { get; set; }
        public virtual int TransactionNo { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
