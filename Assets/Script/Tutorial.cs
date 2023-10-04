using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Image image;
    public Text pular;
    public Text andar_D;
    public Text andar_E;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(Direcional());
    }

    IEnumerator Direcional()
    {   
        image.enabled = false;
        pular.enabled = false;
        andar_D.enabled = false;
        andar_E.enabled = false;
        yield return new WaitForSeconds(1);
        image.enabled = true;
        pular.enabled = true;
        andar_D.enabled = true;
        andar_E.enabled = true;
        yield return new WaitForSeconds(4);
        image.enabled = false;
        pular.enabled = false; 
        andar_D.enabled = false;
        andar_E.enabled = false;
        
    }
}
