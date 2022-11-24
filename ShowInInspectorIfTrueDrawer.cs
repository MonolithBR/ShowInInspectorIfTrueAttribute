using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ShowInInspectorIfTrueAttribute))]
public class ShowInInspectorIfTrueDrawer : PropertyDrawer
{
    private bool m_ShowInInspector;
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return m_ShowInInspector ? base.GetPropertyHeight(property, label) : 0;
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var condProp = property.serializedObject.FindProperty(((ShowInInspectorIfTrueAttribute)attribute).conditionProperty);
        m_ShowInInspector = condProp.boolValue;
        if (m_ShowInInspector) 
        {
            EditorGUI.PropertyField(position, property, label);
        }
    }
}