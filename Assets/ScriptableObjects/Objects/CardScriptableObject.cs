using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScriptableObject : ScriptableObject
{
    public string cardName;

    public int manaCost;
    public int attack;
    public int health;

    public Sprite cardImage;
}
