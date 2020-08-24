using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsAgainstHumanityLibrary
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	internal sealed class ClientIgnoreAttribute : Attribute
	{
		public ClientIgnoreAttribute()
		{
		}
	}
}