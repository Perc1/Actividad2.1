using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Figura : MonoBehaviour
{


    [SerializeField] private Button calculateButton;
    private Action<float> callback;

    public void Init(Action<float> callback)
    {
        calculateButton.onClick.AddListener(() => CalcularArea());
        this.callback = callback;
    }

    private void CalcularArea() 
    {
        //Debug.Log(GetArea());
        callback?.Invoke(GetArea());
    }

    protected abstract float GetArea(); 
}
