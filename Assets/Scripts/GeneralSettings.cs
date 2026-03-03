using UnityEngine;
using UnityEngine.UIElements;

public class GeneralSettings
{
    private SliderInt lookSensitivity;
    float currentLookSensitivity = 0;

    public GeneralSettings(VisualElement root)
    {
        lookSensitivity = root.Q<SliderInt>("look-sensitivity");

        lookSensitivity.value = Mathf.RoundToInt(currentLookSensitivity * 100);

        lookSensitivity.RegisterValueChangedCallback(evt =>
        {
            currentLookSensitivity = Mathf.Clamp((float)lookSensitivity.value / 100f, 0.1f, 1f);
        });
    }
}