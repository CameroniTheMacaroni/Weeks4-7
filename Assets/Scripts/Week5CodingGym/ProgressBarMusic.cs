using UnityEngine;
using UnityEngine.UI;

public class ProgressBarMusic : MonoBehaviour
{
    public Slider progressBar;
    public AudioSource audioSource;
    public float audioLength;
    public bool isPlaying;//toggle with button press
    public SpinScript spinScr;
    void Start()
    {
        audioLength = audioSource.clip.length;
        progressBar.maxValue = audioLength;
    }


    void Update()
    {
        if (isPlaying)
        {
            progressBar.value += Time.deltaTime;

            if(progressBar.value >= progressBar.maxValue)
            {
                isPlaying = false;
                spinScr.endRotation();
                progressBar.value = 0f;
            }
        }
    }
    public void turnOnMusic()
    {
        isPlaying = true;
    }
}
