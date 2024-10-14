using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public Text playerNameText;
    void Awake()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }

    [SerializeField] private Text displayTime;

    private IEnumerator Start()
    {
        while (true)
        {
            displayTime.text = Time.GetCurrntTime();
            yield return new WaitForSeconds(1f);
        }
    }
}
