﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HARDselect : MonoBehaviour
{
    [SerializeField]

    Fade fade = null;



    public void Fadeout()

    {


        fade.FadeIn(1, () => {

            Invoke("LoadScene", 0.5f);

        });

    }

    public void LoadScene()
    {

        SceneManager.LoadScene("HARD");

    }
}
