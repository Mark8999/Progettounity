using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyscoreText;
    public static int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        //MyscoreText.text = "Exp : " + ScoreNum;
    }
    private void Update()
    {
        MyscoreText.text = "Exp : " + ScoreNum;
    }



}
    

