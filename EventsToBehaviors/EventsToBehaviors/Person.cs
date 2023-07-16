﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventsToBehaviors
{
	public class Person
	{
        public string Name { get; set; }
        public int Age { get; set; }

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}";
		}
	}
}
