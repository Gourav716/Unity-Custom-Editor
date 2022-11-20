using UnityEngine;
using UnityEditor;

[UnityEditor.CustomEditor(typeof(MaterialAssign))]
public class CustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MaterialAssign materialAssign = (MaterialAssign)target;

        GUILayout.BeginHorizontal();
            if (GUILayout.Button("Assign Material"))
            {
                materialAssign.ChangeMaterial();
            }
        GUILayout.EndHorizontal();
    }
}
