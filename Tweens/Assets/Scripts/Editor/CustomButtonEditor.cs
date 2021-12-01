using UnityEditor;
using UnityEditor.UI;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomEditor(typeof(CustomButton))]
public class CustomButtonEditor : ButtonEditor
{
    private SerializedProperty m_InteractableProperty;

    protected override void OnEnable()
    {
        m_InteractableProperty = serializedObject.FindProperty("m_Interactable");
    }

    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();

        var changeButtonType = new PropertyField(serializedObject.FindProperty(CustomButton.ChangeButtonType));

        root.Add(changeButtonType);
        root.Add(new IMGUIContainer(OnInspectorGUI));


        return root;
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();


        EditorGUILayout.PropertyField(m_InteractableProperty);
        EditorGUI.BeginChangeCheck();

        serializedObject.ApplyModifiedProperties();


    }
}
