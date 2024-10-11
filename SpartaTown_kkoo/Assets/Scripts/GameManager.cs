using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Basic, Pink
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public Character currentCharacter;
}