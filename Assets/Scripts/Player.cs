using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public bool isTouchTop;
    public bool isTouchBottom;
    public bool isTouchRight;
    public bool isTouchLeft;
    Collider2D collision;


    void Start()
    {
        collision = GetComponent<Collider2D>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if ((isTouchRight && h == 1 || isTouchLeft && h == -1))
            h = 0;

        float v = Input.GetAxisRaw("Vertical");
        if ((isTouchTop && v == 1 || isTouchBottom && v == -1))
            v = 0;

        Vector3 curpos = transform.position;
        Vector3 nextpos = new Vector3(h, v, 0) * speed * Time.deltaTime;

        transform.position = curpos + nextpos;
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Border")
        {
            switch(collision.gameObject.name)
            {
                case "Top":
                    isTouchTop = true;
                    break;
                case "Bottom":
                    isTouchBottom = true;
                    break;
                case "Right":
                    isTouchRight = true;
                    break;
                case "Left":
                    isTouchLeft = true;
                    break;

            }
        }
        if (collision.gameObject.tag == "Store")
            SceneManager.LoadScene("Store");
       
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Top":
                    isTouchTop = false;
                    break;
                case "Bottom":
                    isTouchBottom = false;
                    break;
                case "Right":
                    isTouchRight = false;
                    break;
                case "Left":
                    isTouchLeft = false;
                    break;

            }
        }
    }


}
