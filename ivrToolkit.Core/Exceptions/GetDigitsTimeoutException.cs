﻿// 
// Copyright 2013 Troy Makaro
// 
// This file is part of ivrToolkit, distributed under the LESSER GNU GPL. For full terms see the included COPYING file and the COPYING.LESSER file.
// 
// 
using System;

namespace ivrToolkit.Core.Exceptions
{
    /// <summary>
    /// Thrown if the number of defined milliseconds has passed since the last digit was pressed.
    /// The default milliseconds is 5000 and can be overridden in voice.properties with the parameter name of 'getDigits.timeoutInMilliseconds'
    /// </summary>
    public class GetDigitsTimeoutException : VoiceException
    {
        /// <inheritdoc/>
        public GetDigitsTimeoutException()
        {
        }
        /// <inheritdoc/>
        public GetDigitsTimeoutException(string message)
            : base(message)
        {
        }
        /// <inheritdoc/>
        public GetDigitsTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
