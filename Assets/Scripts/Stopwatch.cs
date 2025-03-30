using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stopwatch : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] float time;
    
    void Update()
    {
        time += Time.deltaTime;
        timerText.text = time.ToString();

        if (time >= 90 ) //Can't win within 90 sec will restart
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
