﻿// ==============================================================================
// 
// EveHQ - An Eve-Online™ character assistance application
// Copyright © 2005-2015  EveHQ Development Team
//   
// This file is part of EveHQ.
//  
// The source code for EveHQ is free and you may redistribute 
// it and/or modify it under the terms of the MIT License. 
// 
// Refer to the NOTICES file in the root folder of EVEHQ source
// project for details of 3rd party components that are covered
// under their own, separate licenses.
// 
// EveHQ is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the MIT 
// license below for details.
// 
// ------------------------------------------------------------------------------
// 
// The MIT License (MIT)
// 
// Copyright © 2005-2015  EveHQ Development Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// ------------------------------------------------------------------------------
// 
// <copyright file="HistoryRowset.cs" company="EveHQ Development Team">
//     Copyright © 2005-2015  EveHQ Development Team
// </copyright>
// 
// ==============================================================================

namespace EveHQ.Market.UnifiedMarketDataFormat
{
    /// <summary>
    ///     Strongly typed history row set.
    /// </summary>
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public class HistoryRowset : UnifiedDataRowset<HistoryRow>
    {
        #region Static Fields

        /// <summary>The column names.</summary>
        private static readonly string[] Columns = { "date", "orders", "quantity", "low", "high", "average" };

        #endregion

        #region Constructors and Destructors

        /// <summary>Initializes a new instance of the <see cref="HistoryRowset" /> class.</summary>
        public HistoryRowset()
        {
            Rows = new List<HistoryRow>();
        }

        #endregion

        #region Public Properties

        /// <summary>Gets the column names.</summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "used for serialization formatting.")]
        public static string[] ColumnNames
        {
            get { return Columns; }
        }

        #endregion
    }
}