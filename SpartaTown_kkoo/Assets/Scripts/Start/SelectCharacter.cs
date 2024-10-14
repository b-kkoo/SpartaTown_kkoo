using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Character character;
    public SelectCharacter[] chars;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        if (GameManager.instance.currentCharacter == character)
        {
            OnSelect();
        }
        else
        {
            OnDeSelect();
        }
    }

    private void OnMouseUpAsButton()
    {
        GameManager.instance.currentCharacter = character;
        OnSelect();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != this)
            {
                chars[i].OnDeSelect();
            }
        }
    }

    private void OnDeSelect()
    {
        anim.SetBool("IsSelected", false);
    }

    private void OnSelect()
    {
        anim.SetBool("IsSelected", true);
    }
}
