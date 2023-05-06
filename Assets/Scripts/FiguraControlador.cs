using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class FiguraControlador
{
    [SerializeField] private Button figuraBoton;
    [SerializeField] private GameObject figuraGameObject;
    [SerializeField] private Figura figura;

    public void Init(Action<float> callback)
    {
        figuraBoton.onClick.AddListener(() => Show());
        figura = figuraGameObject.GetComponent<Figura>();
        figura.Init(callback);
    }

    private void Show()
    {
        figuraGameObject.SetActive(true);
    }
}
