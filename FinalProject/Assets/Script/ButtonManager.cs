using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
public void ModeScene(){
    SceneManager.LoadScene("Mode");
}
public void Option(){
    SceneManager.LoadScene("Option");
}
public void MainScene(){
    SceneManager.LoadScene("MainScene");
}
public void BeastFight(){
    SceneManager.LoadScene("BeastFight");
}
public void RivalFight(){
    SceneManager.LoadScene("RivalFight");
}
public void Quitapplication(){
    Application.Quit();
}
public void Credits(){
    SceneManager.LoadScene("Credits");
}
}
