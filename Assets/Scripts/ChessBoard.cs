using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    public GameObject whiteTile;
    public GameObject blackTile;

    public GameObject pawn;
    public GameObject rook;
    public GameObject knight;
    public GameObject bishop;
    public GameObject queen;
    public GameObject king;


    public int width = 8;
    public int height = 8;
    public float tileSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Instantiate(blackTile, new Vector3(i * tileSize, j * tileSize, 0), Quaternion.identity, transform);
                }
                else
                {
                    Instantiate(whiteTile, new Vector3(i * tileSize, j * tileSize, 0), Quaternion.identity, transform);
                }
            }
        }
        float offsetX = (width - 1) * tileSize / 2f;
        float offsetY = (height - 1) * tileSize / 2f;
        transform.position = new Vector3(-offsetX, -offsetY, 0);
    }
    void GeneratePieces()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                switch (i)
                {
                    case 0:
                        SpriteRenderer sr = pawn.GetComponent<SpriteRenderer>();
                        Instantiate(pawn, new Vector3(i * tileSize, j * tileSize, 0), Quaternion.identity, transform);
                        break;

                }
            }
        }
    }
}
