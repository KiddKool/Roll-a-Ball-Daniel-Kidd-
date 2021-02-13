using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject LevelCompleteUI;
    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
    }
}
