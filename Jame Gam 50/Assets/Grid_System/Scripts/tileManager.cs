using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class tileManager : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer renderer, specRenderer;
    [SerializeField] private Transform tile;
    [SerializeField] private GameObject highlight, specTile;
    [SerializeField] private Sprite wallSprite, momBlueWhaleSprite;
    [SerializeField] private GameObject babyBlueWhale;
    public List<Vector2> occupiedTiles;
    public void Init(bool isOffset, string tag)
    {

        renderer.color = isOffset ? offsetColor : baseColor;

            if (tag == "wall")
            {
                specRenderer.sprite = wallSprite;
                specTile.SetActive(true);
            }
            if (tag == "momBlueWhale")
            {
                specRenderer.sprite = momBlueWhaleSprite;
                specTile.SetActive(true);
            }
            if (tag == "babyBlueWhale")
            {
                babyBlueWhale.SetActive(true);
                babyBlueWhale.transform.position = tile.transform.position;
                occupiedTiles.Add(transform.position);
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