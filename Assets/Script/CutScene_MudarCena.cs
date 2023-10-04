using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene_MudarCena : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene("Fase 3");
     
    }
}
