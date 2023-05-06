using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIControlador : MonoBehaviour
{
    [SerializeField] private List<FiguraControlador> shapeControllerList;
    [SerializeField] private TextMeshProUGUI resultText;

    void Start()
    {
        foreach (var shapeController in shapeControllerList)
        {
            shapeController.Init(ShowResult);
        }
    }

    private void ShowResult(float result)
    {
        resultText.text = $"El resultado es {result}";
    }
}
