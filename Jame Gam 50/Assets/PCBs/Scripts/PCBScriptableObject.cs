using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu(fileName = "PCB", menuName = "ScriptableObjects/PCB", order = 1)]
public class PCBScriptableObject : ScriptableObject
{
    public int ID;
    public int numberOfPrefabsToCreate;
    public string PCBName;
    public string description;
    public MonoBehaviour effect;
}