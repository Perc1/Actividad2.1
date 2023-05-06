using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrianguloContenido : Figura
{


    [SerializeField] private TMP_InputField TrianguloB;
    [SerializeField] private TMP_InputField TrianguloH;

    protected override float GetArea()
    {
        float b = float.Parse(TrianguloB.text);
        float h = float.Parse(TrianguloH.text);
        return b * h /2;
    }
}
