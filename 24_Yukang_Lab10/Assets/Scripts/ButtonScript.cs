using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    public GameObject GameOverUI;
    // Start is called before the first frame update
    public void Reset()
    {
        GameOverUI.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
