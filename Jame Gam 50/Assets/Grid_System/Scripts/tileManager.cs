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
    [SerializeField] private Sprite wallSprite, momBlueWhaleSprite, momPinkWhaleSprite;
    [SerializeField] private GameObject babyBlueWhale, babyPinkWhale;
    public List<Vector2> occupiedTiles;
    public void Init(bool isOffset, string tag)
    {

        renderer.color = isOffset ? offsetColor : baseColor;

            if (tag == "wall")
            {
                specRenderer.sprite = wallSprite;
                specTile.SetActive(true);
                occupiedTiles.Add(transform.position);
            }
            if (tag == "momBlueWhale")
            {
                specRenderer.sprite = momBlueWhaleSprite;
                specTile.SetActive(true);
            }
            if (tag == "momBlueWhale")
            {
                specRenderer.sprite = momPinkWhaleSprite;
                specTile.SetActive(true);
            }
            if (tag == "babyBlueWhale")
            {
                Instantiate(babyBlueWhale, transform.position, Quaternion.identity);
                babyBlueWhale.SetActive(true);
                babyBlueWhale.transform.eulerAngles = new Vector3(0, 0, 0);
                occupiedTiles.Add(transform.position);
            }
            if (tag == "babyPinkWhale")
            {
                Instantiate(babyPinkWhale, transform.position, Quaternion.identity);
                babyPinkWhale.SetActive(true);
                babyPinkWhale.transform.eulerAngles = new Vector3(0, 0, 0);
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