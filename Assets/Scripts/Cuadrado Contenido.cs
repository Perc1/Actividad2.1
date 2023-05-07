using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CuadradoContenido : Figura
{

    [SerializeField] private TMP_InputField CuadradoL;


    protected override float GetArea()
    {
        float l = float.Parse(CuadradoL.text);
        return l * l;
    }
}
