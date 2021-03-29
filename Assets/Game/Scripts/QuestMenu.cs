﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject questMenu;
    public TextMeshProUGUI mText;

    private void Start()
    {
        questMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (PauseMenu.isPaused || PauseMenu.inStory)
            return;

        int level = SceneManager.GetActiveScene().buildIndex;
        switch (level)
        {
            case 0:
                mText.text = "What is going on?\nI have to talk to the priest near the church.\nHe might know what is happening";
                break;
            case 1:
                mText.text = "So the van is broken down..\nI have to find the mechanic and ask him for help.\nIf we dont get out soon then we'll all lose our lives.";
                break;
            case 2:
                mText.text = "The note from the mechanic said to find him at his summer house near the lake.\nThank god I found a working car, although very little gas so I only go so far.";
                break;
            case 3:
                mText.text = "I should be able to find Jacob's tools I need here.\nI have to be careful though, I hear strange noises up ahead.\nI have to find a doctor soon too, the wound didn't look so good.";
                break;
            case 4:
                mText.text = "I should be able to find someone near the hospital in the distance.\nOr at least some drugs to help Jacob a little.";
                break;
            default:
                mText.text = "Level 5";
                break;
        }
        if (Input.GetKeyDown("k"))
        {
            if (isPaused == false)
            {
                questMenu.SetActive(true);
                isPaused = true;
            }
            else
            {
                questMenu.SetActive(false);
                isPaused = false;
            }
        }
    }
}
