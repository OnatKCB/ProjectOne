using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Menu : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject pGenerator;
    //public GameObject nextPuzzleButton;
    public GameObject SuccessPanel;
    public GameObject EndGamePanel;

    Puzzle_Manager pm;


    void Start()
    {
        pm = (Puzzle_Manager)FindObjectOfType(typeof(Puzzle_Manager));
    }
    public void StartTheGame() 
    {
        Time.timeScale = 1.0f;
        StartPanel.SetActive(false);
        pGenerator.SetActive(true);
        //nextPuzzleButton.SetActive(true);
    }
    public void EndTheGame() 
    {
        Time.timeScale = 0f;
        EndGamePanel.SetActive(true);
        pGenerator.SetActive(false);
    }

    public IEnumerator GetHereSuccessScreen()
    {
        SuccessPanel.SetActive(true);
        yield return new WaitForSeconds(5);
        SuccessPanel.SetActive(false);
        yield return new WaitForSeconds(1);
    }
    public void restartPuzzle()
    {
        Time.timeScale = 1.0f;
        EndGamePanel.SetActive(false);
        pm.newPuzzle();
        pGenerator.SetActive(true);
    }
}