/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.1.1 - Ext.NET Community License (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class MonthViewBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractCalendarView.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool showHeader = false;

			/// <summary>
			/// True to display a header beneath the navigation bar containing the week names above each week's column, false not to show it and instead display the week names in the first row of days in the calendar (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ShowHeader 
			{ 
				get
				{
					return this.showHeader;
				}
				set
				{
					this.showHeader = value;
				}
			}

			private bool showTime = true;

			/// <summary>
			/// True to display the current time in today's box in the calendar, false to not display it (defautls to true)
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowTime 
			{ 
				get
				{
					return this.showTime;
				}
				set
				{
					this.showTime = value;
				}
			}

			private bool showTodayText = true;

			/// <summary>
			/// True to display the todayText string in today's box in the calendar, false to not display it (defautls to true)
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowTodayText 
			{ 
				get
				{
					return this.showTodayText;
				}
				set
				{
					this.showTodayText = value;
				}
			}

			private bool showWeekLinks = false;

			/// <summary>
			/// True to display an extra column before the first day in the calendar that links to the view for each individual week, false to not show it (defaults to false). If true, the week links can also contain the week number depending on the value of showWeekNumbers.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ShowWeekLinks 
			{ 
				get
				{
					return this.showWeekLinks;
				}
				set
				{
					this.showWeekLinks = value;
				}
			}

			private bool showWeekNumbers = false;

			/// <summary>
			/// True to show the week number for each week in the calendar in the week link column, false to show nothing (defaults to false). Note that if showWeekLinks is false this config will have no affect even if true.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ShowWeekNumbers 
			{ 
				get
				{
					return this.showWeekNumbers;
				}
				set
				{
					this.showWeekNumbers = value;
				}
			}

			private string weekLinkOverClass = "ext-week-link-over";

			/// <summary>
			/// The CSS class name applied when the mouse moves over a week link element (only applies when showWeekLinks is true, defaults to 'ext-week-link-over').
			/// </summary>
			[DefaultValue("ext-week-link-over")]
			public virtual string WeekLinkOverClass 
			{ 
				get
				{
					return this.weekLinkOverClass;
				}
				set
				{
					this.weekLinkOverClass = value;
				}
			}

        }
    }
}