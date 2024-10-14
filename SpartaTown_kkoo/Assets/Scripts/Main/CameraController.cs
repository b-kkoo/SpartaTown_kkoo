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
        //ī�޶� ��ġ ����
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        //�̸� ��ġ ����
        playerName.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));
    }
}
