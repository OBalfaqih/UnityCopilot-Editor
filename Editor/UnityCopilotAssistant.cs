using UnityEngine;
using UnityEditor;

public class UnityCopilotAssistant : MonoBehaviour
{
    [MenuItem("CONTEXT/Object/Go to Unity Copilot")]
    static void GoToUnityCopilot(MenuCommand command)
    {
        string component = command.context.GetType().Name;
        Application.OpenURL("https://unitycopilot.com/search?q=" + component + "#results");
    }
}
