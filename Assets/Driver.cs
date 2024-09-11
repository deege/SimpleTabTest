using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Driver : MonoBehaviour
{
    void Start()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;
        var startButton = root.Q<Button>("start-button");
        startButton.Focus();
    }

}
