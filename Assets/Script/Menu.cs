using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Texture2D cursorTexture;

  
    void Start()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero,
            CursorMode.ForceSoftware);
    }


    public void Jogar()
    {
        
        SceneManager.LoadScene("Tutorial");
    }


    public void Sair()
    {

        Application.Quit();
    }

}
