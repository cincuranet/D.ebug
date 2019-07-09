using System.Diagnostics;

public static class D
{
	[DebuggerStepThrough]
	public static void ebug()
	{
		if (Debugger.IsAttached)
			Debugger.Break();
		else
			Debugger.Launch();
	}
}