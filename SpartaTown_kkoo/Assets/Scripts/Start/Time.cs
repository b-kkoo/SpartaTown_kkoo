using System;
using UnityEngine;

public class Time : MonoBehaviour
{
    public static string GetCurrntTime()
    {
        // 현재 시, 분 출력
        return DateTime.Now.ToString(("HH : mm : ss"));
    }
}
