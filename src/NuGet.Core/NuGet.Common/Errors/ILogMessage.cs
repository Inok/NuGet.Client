﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Common
{
    public interface ILogMessage
    {
        /// <summary>
        /// Level to indicate if this is an error or wanring.
        /// </summary>
        LogLevel Level { get; set; }

        /// <summary>
        /// Level to indicate the warning level for the message.
        /// This is relevant only if the Level == LogLevel.Warning.
        /// </summary>
        WarningLevel WarningLevel { get; set; }

        /// <summary>
        /// Indicates the error code.
        /// </summary>
        NuGetLogCode Code { get; set; }

        /// <summary>
        /// Indicates the staring generated by the code to go with the error code.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Indicates the project for which the error was thrown.
        /// </summary>
        string ProjectPath { get; set; }

        /// <summary>
        /// Indicates the date time at which the error occurred.
        /// </summary>
        DateTimeOffset Time { get; set; }

        /// <summary>
        /// Converts the ILogMessage into a string that can be logged as-is into a Console.
        /// </summary>
        /// <returns>The string representation of the ILogMessage.</returns>
        string FormatMessage();

        /// <summary>
        /// Converts the ILogMessage into a string that can be logged as-is into a Console.
        /// </summary>
        /// <returns>The string representation of the ILogMessage.</returns>
        Task<string> FormatMessageAsync();
    }
}
