using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bombSpawner : MonoBehaviour
{
    public GameObject bomb;
    List<Vector2> posList = new List<Vector2>();
    


    void Start()
    {
        for(float x = -20; x<=20; x++)
        {
            for(float y = -10; y<=10; y++)
            {
                if (Mathf.Abs(x) > 10 || Mathf.Abs(y) > 5)
                { 
                    posList.Add(new Vector2(x, y));
                    
                }
            }
        }
        
        
        StartCoroutine(RandomBombSpawn());
    }

    
    void Update()
    {

     
    }

    IEnumerator RandomBombSpawn()
    {
       

        while (true)
        {
            int index = Random.Range(0, posList.Count);

            Vector2 randomPos = posList[index];
            
            Instantiate(bomb, randomPos, Quaternion.identity);

            yield return new WaitForSeconds(gameManager.instance.beklemeSuresi);

        }
    }
}
