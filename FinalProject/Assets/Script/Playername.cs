using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Playername : MonoBehaviour
{
    public static Playername scene1;
    public TMP_InputField inputField1, inputField2 ;
   public   string player1_name, player2_name ;
 public void Awake()
 {
    if (scene1 == null)
    {
        scene1 = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(gameObject);
    }
 }

 public void SetPlayerName(){            
           player1_name = inputField1.text;
           player2_name = inputField2.text;
    SceneManager.LoadSceneAsync("BeastFight");
    
 }
}
