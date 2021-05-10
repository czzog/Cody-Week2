using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Replay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
