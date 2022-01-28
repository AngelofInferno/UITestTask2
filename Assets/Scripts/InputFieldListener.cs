using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldListener : MonoBehaviour
{
    [SerializeField] private InputField inputField;

    private void TestOnValueChanged()
    {
        print($"From changed event: {inputField.text}");
    }

    private void TestOnEditChanged()
    {
        print($"From end event: {inputField.text}");
    }

    private void Start()
    {
        inputField.onValueChanged.AddListener(delegate(string str)
        {
            print($"FROM CODE!!! changed {str}");
        });
        
        inputField.onEndEdit.AddListener(delegate(string str)
        {
            print($"FROM CODE!!! end {str}");
        });
    }
}
