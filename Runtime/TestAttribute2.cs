#region Access
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEditor;
using XavHelpTo;
#endregion

//[Serializable]
//[ClassInterface(ClassInterfaceType.None)]
//[ComDefaultInterface(typeof(_Attribute))]
//[ComVisible(true)]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
//[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
//[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public class TestAttribute2: PropertyAttribute{
    public TestAttribute2() => "Test !".Print("null");
    public TestAttribute2(string color) => "Test !".Print(color);
}