using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Ball_Manipulator : MonoBehaviour
{
    public GameObject Player_Ball;
    public Button Player_Button;
    public GameObject Player_Success_Zone;
    //public GameObject obstacle;

    void Start()
    {
        Player_Button.onClick.AddListener(ActiveRb);
        //obstacle.SetActive(false);
    }

    void ActiveRb() 
    {
        Player_Ball.SetActive(true);
        //obstacle.SetActive(true);
    }
    
}