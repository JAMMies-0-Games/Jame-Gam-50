using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCBManager : MonoBehaviour
{
    public GameObject scene;
    private scene_logic s_logic;
    private void Start()
    {
        s_logic = scene.GetComponent<scene_logic>();
    }

    public PCBScriptableObject PCBValues;
    public List<int> prefabsNum = new List<int>{5,3,1,2,5,8,3,1,4,4};
    public SceneManager SceneManager;
    
    public void GeneratePCBs()
    {
        for (int i = 0; i < prefabsNum[s_logic.curScene]; i++)
        {
            Debug.Log("ID: " + PCBValues.ID + " Name: " + PCBValues.PCBName + " Description: " + PCBValues.description);
        }
    }
}
