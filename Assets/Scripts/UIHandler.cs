using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIDocument root = GetComponent<UIDocument>();
        new GeneralSettings(root.rootVisualElement);
    }
}
