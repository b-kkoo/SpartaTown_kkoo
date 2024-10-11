using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private GameObject playerName;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");

        playerName = GameObject.Find("Canvas/PlayerName");
    }

    public void LateUpdate()
    {
        //카메라 위치 조정
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        //이름 위치 조정
        playerName.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));
    }
}
