﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
	public class Result : IResult
	{
        public Result(string message, bool success) : this(success)
        {
            Message = message;
            
        }
		public Result(bool success)
		{
			
			Success = success;
		}

		public string Message { get; }

        public bool Success {  get; }

		
	}
}
