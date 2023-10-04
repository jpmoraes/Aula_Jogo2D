using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Cursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    void Start()
    {
     
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
