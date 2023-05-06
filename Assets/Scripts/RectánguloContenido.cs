using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RectánguloContenido : Figura
{
    [SerializeField] private TMP_InputField RectanguloB;
    [SerializeField] private TMP_InputField RectanguloH;

    protected override float GetArea()
    {
        float b = float.Parse(RectanguloB.text);
        float h = float.Parse(RectanguloH.text);
        return b * h;
    }
}
