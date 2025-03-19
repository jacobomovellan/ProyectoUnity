using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBoton : MonoBehaviour
{
    public GameObject panelControles;

    public void Jugar()
    {
     
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        
        Debug.Log("Salir...");
        Application.Quit();
    }

    public void Opciones()
    {

        if (panelControles != null)
        {
            panelControles.SetActive(!panelControles.activeSelf);
        }
    }
}

