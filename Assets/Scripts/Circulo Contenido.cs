using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CirculoContenido : Figura
{

    [SerializeField] private TMP_InputField CirculoR;

    public const float PI = 3.14f;

    protected override float GetArea()
    {

        float r = float.Parse(CirculoR.text);

        return (PI* r * r);
    }
} 
