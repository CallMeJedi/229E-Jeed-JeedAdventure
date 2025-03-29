using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stopwatch : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] float time;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timerText.text = time.ToString();

        if (time >= 90 )
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
