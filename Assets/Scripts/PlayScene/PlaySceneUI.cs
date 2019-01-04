﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StarSeeker.GameScene
{
    public class PlaySceneUI : MonoBehaviour
    {
        [SerializeField] private Text StageText;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            StageText.text = "바닥 수 : " + GameManager.Instance.GetStage();
        }
    }
}
