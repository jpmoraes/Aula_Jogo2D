using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int speed;
    public int jump;
    Rigidbody2D rgb;
    SpriteRenderer sr;
    Animator anim;
    private bool pulo;
    private bool skill_run;
    public GameObject enemy;
    public int lifePlayer =3 ;


    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();

        sr = GetComponent<SpriteRenderer>();

        anim = GetComponent<Animator>();

        skill_run = true;

        
    }

    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            anim.SetBool("Run", true);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            
            


        }else if (Input.GetKey(KeyCode.LeftArrow))
        {

            sr.flipX = true;
            anim.SetBool("Run", true);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            


        }
        else
        {

            anim.SetBool("Run", false);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && pulo == true)
        { 

            rgb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            anim.SetBool("Jump", true);
            pulo = false;


        }
   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "plataforma" || collision.gameObject.layer == 8)
        {
            anim.SetBool("Jump", false);
            pulo = true;
        }

        if (collision.gameObject.tag == "Enemy" &&
                 transform.position.y <= enemy.transform.position.y)
        {
            lifePlayer--;


            if (lifePlayer <= 0) { 
            
               transform.position = new Vector3(-5, 5, 0);
        
            }

        }
        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "arvore" && skill_run == true)
        {

            SceneManager.LoadScene("Fase 2");
            speed += 5;
            skill_run = false;
        
        }


        if(collision.gameObject.layer == 3)
        {
            SceneManager.LoadScene("Menu");
        }
    }


}
