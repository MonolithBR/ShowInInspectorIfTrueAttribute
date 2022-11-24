using System;
using System.Collections;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class ShowInInspectorIfTrueAttribute : PropertyAttribute
{
    public string conditionProperty;
    public ShowInInspectorIfTrueAttribute(string conditionProperty) { this.conditionProperty = conditionProperty; }
}