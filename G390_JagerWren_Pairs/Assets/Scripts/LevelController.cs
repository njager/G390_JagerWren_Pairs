using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape")){
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Level 1 End"))
        {
            SceneManager.LoadScene("Level2");
        }
        if (other.CompareTag("Level 2 End"))
        {
            SceneManager.LoadScene("Level3");
        }
        if (other.CompareTag("Level 3 End"))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
