using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CirculoEscena : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Circulo");
    }
}