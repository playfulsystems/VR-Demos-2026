// Assets/Editor/SelectSceneOnPlay.cs
using UnityEditor;

[InitializeOnLoad]
public static class UnselectOnPlay
{
    // ✅ Static constructor: must match the class name AND include ()
    static UnselectOnPlay()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        if (state == PlayModeStateChange.ExitingEditMode)
        {
            Selection.activeObject = null;
            Selection.objects = System.Array.Empty<UnityEngine.Object>();
        }
    }
}