using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CuadradoEscena : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Cuadrado");
    }
}