using System.Diagnostics;

public static class D
{
	[DebuggerHidden]
	public static void ebug()
	{
		if (Debugger.IsAttached)
			Debugger.Break();
		else
			Debugger.Launch();
	}
}