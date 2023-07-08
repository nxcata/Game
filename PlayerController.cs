using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float limite = 1;
    public float velocidad = 1.5f;
    public float salto = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x < limite)
        {
            gameObject.transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x > -limite)
        {
            gameObject.transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Translate(0, salto, 0);
        }
    }
}
