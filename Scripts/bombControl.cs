using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bombControl : MonoBehaviour
{
    private GameObject hedef;
    
    void Start()
    {
        hedef = GameObject.Find("Space Ship");
    }

    
    void Update()
    {
        if (hedef != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, hedef.transform.position, gameManager.instance.speed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        gameManager.instance.skor += 1;
        gameManager.instance.speed += 0.3f;
        gameManager.instance.beklemeSuresi -= 0.1f;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("SPACESHIP"))
        {
            
            Time.timeScale = 0f;
            
            gameManager.instance.speed = 2f;
            gameManager.instance.gameOver.SetActive(true);

        }


    
    }

   
}
