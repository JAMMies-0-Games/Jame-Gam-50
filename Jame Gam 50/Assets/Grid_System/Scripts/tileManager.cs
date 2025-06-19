using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer renderer, specRenderer;
    [SerializeField] private GameObject highlight, specTile;
    [SerializeField] private Sprite wallSprite;

    public void Init(bool isOffset, string tag)
    {
        renderer.color = isOffset ? offsetColor : baseColor;
        if (tag != null)
        {
            if (tag == "wall")
            {
                specRenderer.sprite = wallSprite;
                specTile.SetActive(true);

            }

        }
    }

    void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        highlight.SetActive(false);
    }
}