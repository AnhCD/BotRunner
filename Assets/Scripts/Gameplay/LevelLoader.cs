using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string sceneToLoad;
    public Animator transition;
    public float transitionTime;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && sceneToLoad == "MenuScene")
        {
            StartCoroutine(LoadScene());
            // SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
        }
        if (Input.GetButtonDown("Fire1") && sceneToLoad == "CreditScene")
        {
            LoadNextScene();
        }
        if (Input.GetButtonDown("Fire1") && sceneToLoad == "StartScene")
        {
            StartCoroutine(LoadScene());
        }
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadNextScene(SceneManager.GetActiveScene().buildIndex +1));
        
    }
    IEnumerator LoadNextScene(int levelIndex)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    IEnumerator LoadScene()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneToLoad);
    }
}
