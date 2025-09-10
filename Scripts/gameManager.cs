using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject spaceShip;

    public static gameManager instance;
    public float beklemeSuresi = 2f;
    public TextMeshProUGUI skorText;
    public float speed = 2f;
    public int skor;
    public TextMeshProUGUI sonucText;
    public GameObject gameOver;


    private void Awake()
    {


        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {

    }


    void Update()
    {


        skorText.text = skor.ToString();
        sonucText.text = skor.ToString();

        spaceShip.transform.Rotate(new Vector3(0, 0, 0.5f));

    }

    public void OyunuBaslat()
    {
        
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void OyunuTekrarla()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void OyunuKapat()
    {
        Application.Quit();
    }

    public void MenuyeGýt()
    {
        SceneManager.LoadScene(0);
    }

   
}

    
    

    



