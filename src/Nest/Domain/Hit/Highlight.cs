﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest
{
	public class Highlight
	{
		public string Field { get; internal set; }
    public IEnumerable<string> Highlights { get; set; }
	}
}
