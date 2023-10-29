using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    #region Declaration - Variable

    public static MainManager instance;    

    #endregion

    #region Function - Unity Events

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {

    }

    #endregion

    #region Function - Load And Unload Scene Handle

    private IEnumerator LoadScene(string sceneName)
    {
        Debug.Log("--- Main Manager: LoadScene(" + sceneName + ")");
        
        // Load Scene By Scene Name
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        // Wait Loading Process Finish
        while (asyncOperation.isDone != true)
        {            
            yield return null;
        }
    }

    private IEnumerator UnloadScene(string sceneName)
    {
        Debug.Log("--- Main Manager: UnloadScene(" + sceneName + ")");

        // Unload Scene By Scene Name
        AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(sceneName);

        // Wait Unloading Process Finish
        while(asyncOperation.isDone != true)
        {
            yield return null;
        }
    }

    #endregion
}
