using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{
   public void EscenaJuego()
    {
        SceneManager.LoadScene("Eleccion");
    }
}
