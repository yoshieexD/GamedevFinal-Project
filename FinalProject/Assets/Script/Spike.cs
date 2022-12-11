using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spike : MonoBehaviour
{
   public int Respawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2d(Collider2D other){
            if(other.CompareTag("Player1")){
                SceneManager.LoadScene(Respawn);
            }
    }
}
