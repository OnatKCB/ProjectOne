using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
    public string level;
    // Start is called before the first frame update

    public void nextLevel() 
    {
        SceneManager.LoadScene(level);
    }
}
