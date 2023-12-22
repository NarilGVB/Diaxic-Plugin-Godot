#if TOOLS
using Godot;
using System;

namespace Diaxic
{
	[Tool]
	public partial class DiaxicController : EditorPlugin
	{
		public override void _EnterTree()
		{
			// Initialization of the plugin goes here.
		}

		public override void _ExitTree()
		{
			// Clean-up of the plugin goes here.
		}
	}
}
#endif