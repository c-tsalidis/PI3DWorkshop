using System;
using System.Collections;
using System.Collections.Generic;
using ctsalidis.Scripts;
using TMPro;
using UnityEngine;

public class PinNumber : MonoBehaviour {
    [SerializeField] private string number = 0.ToString();
    [SerializeField] private PinCodeManager _pinCodeManager;

    private TMP_Text _text;

    private void Start() {
        _text = GetComponentInChildren<TMP_Text>();
        _text.text = number;
    }

    public void AddNumberToPin() {
        _pinCodeManager.AddToPinCode(number);
        UIManager.StatusMessage = "Number " + number + " added to pin code";
    }
}
