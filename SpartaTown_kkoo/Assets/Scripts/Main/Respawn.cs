using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject player;

    public void Awake()
    {
        player = Instantiate(charPrefabs[(int)GameManager.instance.currentCharacter]);
        player.transform.position = transform.position;
    }
}
