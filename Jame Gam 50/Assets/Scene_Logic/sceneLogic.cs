using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_logic : MonoBehaviour
{
    public PCBManager PCBManager;
    public int curScene = 0;

    private bool hasInitialized = false;

    private void resetScene()
    {
        Debug.Log("Scene Advanced");
        //SceneManager.LoadScene(curScene);
        PCBManager.GeneratePCBs();
    }

    private void nextScene()
    {
        curScene++;
        resetScene();
    }

    void Update()
    {
        if (!hasInitialized)
        {
            hasInitialized = true;
            FirstFrameInit();
        }

        if (Input.GetKeyDown(KeyCode.Space)) // to be changed
        {
            nextScene();
        }
    }

    void FirstFrameInit()
    {
        resetScene();
    }

}
