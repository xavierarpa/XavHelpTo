#region Access
using System;
using UnityEngine;
using XavHelpTo;
#endregion
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class TestAttribute2: PropertyAttribute{
    /// <summary>
	/// Testeo
	/// </summary>
    public TestAttribute2() => "Test !".Print("null");
    /// <summary>
	/// Testeo 2
	/// </summary>
	/// <param name="color"></param>
    public TestAttribute2(string color) => "Test !".Print(color);
}