using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ScriptMenu : MonoBehaviour
{

    public void Jugar(string jugar)
    {
        SceneManager.LoadScene(jugar);
    }
  public void Salir()
  {
    Application.Quit();
    Debug.Log("Aqui se cierra el juego...");
  }  
}
