using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    int rotation, tempo;
    bool colidiu = true;
    int andar = 50;
    bool volta = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        GiraEnemy();
        SobeDesceEnemy();
        //MovimentaEnemy();


        if (player.transform.position.x <= this.transform.position.x - 5f ||
                player.transform.position.x >= this.transform.position.x + 5f)
        {

            Movimenta_Enemy();
        }
       
 
       

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "esq")
        {
            colidiu = true;
        }

        if (collision.gameObject.tag == "dir")
        {
            colidiu = false;
        }
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" &&
                player.transform.position.y > transform.position.y)
        {
            Destroy(this.gameObject);

        }

    }


    //INIMIGO ANDA PARA UM LADO E PARA O OUTRO
    void MovimentaEnemy()
    {

        
        if (this.gameObject.layer == 9 && colidiu == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            this.transform.Translate(Vector2.left * 5 * Time.deltaTime);

        }
        else if (this.gameObject.layer == 9 && colidiu == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            this.transform.Translate(Vector2.right * 5 * Time.deltaTime);

        }
    }


    //INIMIGO SOBE E DESCE
    void SobeDesceEnemy()
    {
        

        if (this.gameObject.layer == 7 && transform.position.y <= 150)
        {

            this.transform.Translate(Vector2.up * 5 * Time.deltaTime);
        }
    }


    //ROTACIONA O INIMIGO
    void GiraEnemy()
    {
        
        rotation += 10;
        tempo += 1;
        if (this.gameObject.layer == 6 && tempo == 20)
        {

            Vector3 newRotation = new Vector3(0, 0, rotation);
            transform.eulerAngles = newRotation;
            tempo = 0;
            if (rotation == 360)
            {
                rotation = 0;
            }

        }
    }


    //INIMIGO ANDA PARA UM LADO E PARA O OUTRO
    void Movimenta_Enemy()
    {


        if (this.gameObject.layer == 9 && andar <= 180 && volta == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            this.transform.Translate(Vector2.left * 5 * Time.deltaTime);

            andar--;

            if(andar == 0)
            {
                volta = false;

            }


        }

        if (this.gameObject.layer == 9 && andar >= 0 && volta ==false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            this.transform.Translate(Vector2.right * 5 * Time.deltaTime);

            andar++;

            if (andar == 180)
            {
                volta = true;

            }
        }
    }

}
