using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName;

    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            // 플레이어의 닉네임을 저장
            PlayerPrefs.SetString("PlayerName", playerName);

            // 게임 시작
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("닉네임을 입력하세요.");
        }
    }
}
