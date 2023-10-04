using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public GameObject player;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;


    void Start()
    {
        life1.GetComponent<SpriteRenderer>().color = Color.green;
        life2.GetComponent<SpriteRenderer>().color = Color.green;
        life3.GetComponent<SpriteRenderer>().color = Color.green;
    }


    void Update()
    {
        BarraLife();

    }

    private void BarraLife()
    {
        if (player.GetComponent<Player>().lifePlayer == 2)
        {
            life1.active = false;

            life2.GetComponent<SpriteRenderer>().color = Color.yellow;
            life3.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        else if (player.GetComponent<Player>().lifePlayer == 1)
        {
            life2.active = false;
            life3.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (player.GetComponent<Player>().lifePlayer == 0)
        {
            life3.active = false;
            player.GetComponent<Player>().lifePlayer = 3;
            life1.active = true;
            life2.active = true;
            life3.active = true;
            life1.GetComponent<SpriteRenderer>().color = Color.green;
            life2.GetComponent<SpriteRenderer>().color = Color.green;
            life3.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }


    public void Menu()
    {
        SceneManager.LoadScene("Menu");

    }

}
