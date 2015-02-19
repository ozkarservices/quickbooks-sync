﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QbSync.QbXml.Struct
{
    public enum DateMacro
    {
        All,
        Today,
        ThisWeek,
        ThisWeekToDate,
        ThisMonth,
        ThisMonthToDate,
        ThisCalendarQuarter,
        ThisCalendarQuarterToDate,
        ThisFiscalQuarter,
        ThisFiscalQuarterToDate,
        ThisCalendarYear,
        ThisCalendarYearToDate,
        ThisFiscalYear,
        ThisFiscalYearToDate,
        Yesterday,
        LastWeek,
        LastWeekToDate,
        LastMonth,
        LastMonthToDate,
        LastCalendarQuarter,
        LastCalendarQuarterToDate,
        LastFiscalQuarter,
        LastFiscalQuarterToDate,
        LastCalendarYear,
        LastCalendarYearToDate,
        LastFiscalYear,
        LastFiscalYearToDate,
        NextWeek,
        NextFourWeeks,
        NextMonth,
        NextCalendarQuarter,
        NextCalendarYear,
        NextFiscalQuarter,
        NextFiscalYear
    }
}
