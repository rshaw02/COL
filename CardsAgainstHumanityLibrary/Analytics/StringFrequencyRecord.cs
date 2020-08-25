using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsAgainstHumanityLibrary.Analytics
{
	internal sealed class StringFrequencyRecord
	{
		[BsonId]
		public string Value { get; set; }
		public int Count { get; set; }
	}
}
