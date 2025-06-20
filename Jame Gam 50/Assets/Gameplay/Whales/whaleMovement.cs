using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

public class whaleMovement : MonoBehaviour
{
    [SerializeField] private Sprite anim1, anim2, anim3, anim4, anim5, anim6, anim7, anim8, anim9, anim10;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private float animSpeed;
    private Vector2 currTile;
    public GameObject[] wallTiles;
    public GameObject tile;
    private tileManager tileManager;

    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(whaleAnimation());
        currTile = GameObject.FindGameObjectWithTag(name).transform.position;
        wallTiles = GameObject.FindGameObjectsWithTag("wall");
    }

    void moveRight(int times)
    {
        for (int i = 0; i < times; i++)
        {
            if (!tileManager.occupiedTiles.Contains(currTile + new Vector2(1,0)))
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                move(1, 0);
            }
        }
    }
    void moveLeft(int times)
    {
        for (int i = 0; i < times; i++)
        {
            if (!tileManager.occupiedTiles.Contains(currTile + new Vector2(-1, 0)))
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                move(-1, 0);
            }
        }
    }

    void moveUp(int times)
    {
        for (int i = 0; i < times; i++)
        {
            if (!tileManager.occupiedTiles.Contains(currTile + new Vector2(0, 1)))
            {
                transform.eulerAngles = new Vector3(0, 0, 90);
                move(0, 1);
            }
        }
    }

    void moveDown(int times)
    {
        for (int i = 0; i < times; i++)
        {
            if (!tileManager.occupiedTiles.Contains(currTile + new Vector2(0, -1)))
            {
                transform.eulerAngles = new Vector3(0, 0, -90);
                move(0, -1);
            }
        }
    }

    IEnumerable move(int x, int y)
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(0.05f);
            transform.position += new Vector3(x, y);
            tileManager.occupiedTiles.Remove(currTile);
            tileManager.occupiedTiles.Add(new Vector2(x, y));
        }
    }

    IEnumerator whaleAnimation()
        {
            renderer.sprite = anim1;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim2;
            yield return new WaitForSeconds(0.16f * animSpeed);
            renderer.sprite = anim3;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim4;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim5;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim6;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim7;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim8;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim9;
            yield return new WaitForSeconds(0.16f * animSpeed);
            renderer.sprite = anim10;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim9;
            yield return new WaitForSeconds(0.16f * animSpeed);
            renderer.sprite = anim8;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim7;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim6;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim5;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim4;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim3;
            yield return new WaitForSeconds(0.08f * animSpeed);
            renderer.sprite = anim2;
            yield return new WaitForSeconds(0.16f * animSpeed);
            StartCoroutine(whaleAnimation());
        }
}