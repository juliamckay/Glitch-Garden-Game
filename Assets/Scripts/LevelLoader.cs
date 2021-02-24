using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //config
    [SerializeField] float loadDelay = 4f;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitAndLoad());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(loadDelay);
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
