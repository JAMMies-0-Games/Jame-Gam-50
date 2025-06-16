using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_logic
{
    public int curScene = 0; // This should reset at loading the first scene

    private void resetScene()
    {
        SceneManager.LoadScene(curScene);
    }

    private void nextScene()
    {
        curScene++;
        resetScene();
    }
}
