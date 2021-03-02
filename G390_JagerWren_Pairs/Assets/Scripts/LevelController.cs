using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    //variables
    AudioSource audioSource;
    public AudioClip cheerSFX;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape")){
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Level 1 End"))
        {
            audioSource.PlayOneShot(cheerSFX);
            SceneManager.LoadScene("Level2");
        }
        if (other.CompareTag("Level 2 End"))
        {
            audioSource.PlayOneShot(cheerSFX);
            SceneManager.LoadScene("Level3");
        }
        if (other.CompareTag("Level 3 End"))
        {
            audioSource.PlayOneShot(cheerSFX);
            SceneManager.LoadScene("Level1");
        }
    }
}
