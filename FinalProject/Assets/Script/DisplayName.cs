using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayName : MonoBehaviour
{
 public TextMeshProUGUI display_player1, display_player2;
 public void Awake(){
    display_player1.text = Playername.scene1.player1_name;
    display_player2.text = Playername.scene1.player2_name;
 }
}
