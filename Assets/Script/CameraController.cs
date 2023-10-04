using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
public class CameraController : MonoBehaviour
{
    public GameObject player;
    public int speed;
    public float y = -1.16f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*y = player.transform.position.y + 2;
        Vector3 posicao = new Vector3(player.transform.position.x, y, 0.0f);
        transform.position = Vector3.Lerp(transform.position, posicao, speed * Time.deltaTime);
        8*/
        Vector3 posicao = new Vector3(player.transform.position.x, y, -124f);
        transform.position = Vector3.MoveTowards(transform.position , posicao, 20 * Time.deltaTime) ;
        transform.position = Vector2.Lerp(transform.position, posicao, 20 * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -125f);

    }
}