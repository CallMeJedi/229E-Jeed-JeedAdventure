using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stopwatch : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] float time = 90f;
    
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = time.ToString();
        
        if (time <= 0 ) //if time out will restart
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
