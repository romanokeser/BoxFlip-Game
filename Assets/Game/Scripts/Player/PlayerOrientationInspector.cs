#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlayerOrientation))]
public class PlayerOrientationInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.Space();

        EditorGUILayout.LabelField("Current Orientation", PlayerOrientation.CurrentOrientation.ToString());
    }
}
#endif
