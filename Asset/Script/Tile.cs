using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tile : MonoBehaviour
{
    public enum TileType
    {
        Blank,
        Ghost, 
        Hint
    }

    public bool iscovered = true;
    public Sprite coveredSprite;
    public TileType tileKind = TileType.Blank;
    public TextMeshPro probability;
    private Sprite defaultSprite;

    void Start( ) {
        defaultSprite = GetComponent<SpriteRenderer>().sprite; 
        GetComponent<SpriteRenderer>().sprite=coveredSprite; 
        
    }

    public void SetIsCovered (bool covered)
     {
  
            iscovered=false; 
            GetComponent<SpriteRenderer>().sprite=defaultSprite;        
    }   
}