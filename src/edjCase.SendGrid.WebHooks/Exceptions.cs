﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edjCase.SendGrid.WebHooks
{
	public class WebHookException : Exception
	{
		public WebHookException(string message) : base(message)
		{
		}
		public WebHookException(string message, Exception ex) : base(message, ex)
		{
		}
	}

	public class WebHookParseException : WebHookException
	{
		public WebHookParseException(string message) : base(message)
		{
		}
		public WebHookParseException(string message, Exception ex) : base(message, ex)
		{
		}
	}

	public class WebHookProcessingException : WebHookException
	{
		public List<Exception> Exceptions { get; }
		public WebHookProcessingException(string message, List<Exception> exceptions) : base(message)
		{
			this.Exceptions = exceptions;
		}
	}
}
