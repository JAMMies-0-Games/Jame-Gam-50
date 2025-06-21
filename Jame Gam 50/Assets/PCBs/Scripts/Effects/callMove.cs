using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class callMove : MonoBehaviour
{
    public GameObject babyBlueWhale, babyPinkWhale;
    private whaleMovement whaleMovement;
    [SerializeField] int timesBlue;
    [SerializeField] string directionBlue;
    [SerializeField] int timesPink;
    [SerializeField] string directionPink;
    [SerializeField] string description;
    [SerializeField] private GameObject toolTip;

    private void OnMouseOver()
    {
        toolTip = GameObject.Find(name);
        toolTip.SetActive(true);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            callMovement();
            Destroy(gameObject);
        }
    }

    private void OnMouseExit()
    {
        toolTip.SetActive(true);
    }

    private void callMovement()
    {

        babyBlueWhale = GameObject.Find("babyBlueWhale");
        for (int i = 0; i < timesBlue; i++)
        {
            if (directionBlue != string.Empty && timesBlue != 0)
            {
                whaleMovement.Invoke("move" + directionBlue, 0);
            }
        }

        babyPinkWhale = GameObject.Find("babyPinkWhale");
        for (int i = 0; i < timesPink; i++)
        {
            if (directionPink != string.Empty && timesPink != 0)
            {
                whaleMovement.Invoke("move" + directionPink, 0);
            }
        }
    }
}
