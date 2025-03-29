using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToyToEnd : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            LoadScene();
        }
    }

    public void LoadScene()
    {
        
            SceneManager.LoadScene("EndingScene");
        
    }
}
 