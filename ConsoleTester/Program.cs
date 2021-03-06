﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTester
{
	class Program
	{
		static void Main( string[] args )
		{
			bool isOpened = Osklib.OnScreenKeyboard.IsOpened();
			Console.WriteLine( "Was opened {0}", isOpened );
			Osklib.OnScreenKeyboard.Show();
			Thread.Sleep( 5000 );
			isOpened = Osklib.OnScreenKeyboard.IsOpened();
			Console.WriteLine( "Now is opened {0}", isOpened );
			bool closed = Osklib.OnScreenKeyboard.Close();
			Console.WriteLine( "Was closed {0}", closed );

			Console.ReadLine();
		}
	}
}
