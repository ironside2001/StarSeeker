﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarSeeker.GameScene
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance; // 싱글턴 패턴

        private void OnDestroy()
        {
            Instance = null;
        }

        private void Awake()
        {
            Instance = this;
        }

        [SerializeField] private GameObject blocks;      // 자동으로 생성할 블럭 프리팹
        [SerializeField] private float blockMakeTerm;   // 블럭이 자동으로 생성되는 주기

        private int stage;                              // 스테이지 [블럭들이 나올수록 증가] 
        private bool gameover = false;                  // 게임오버 [게임오버가 되면 게임 중지]
        private int energy = 0;                         // 스킬 사용할 때 쓰이는 에너지
        public int Energy                             
        {
            get { return energy; }
            set { energy = value; }
        }

        // Start is called before the first frame update
        private void Start()
        {
            StartCoroutine("MakeBlock");
            stage = 0;
        }

        // Update is called once per frame
        private void Update()
        {

        }

        private IEnumerator MakeBlock() // blockMakeTerm을 주기로 block프리팹을 자동으로 생성 
        {
            while (!gameover)
            {
                Instantiate(blocks, new Vector2(0, -5), Quaternion.identity);

                stage++;
                yield return new WaitForSeconds(blockMakeTerm);
            }
        }
        
        private void SetEnergy()
        {

        }

        private void GameOver()     // 게임오버를 참으로 변경
        {
            gameover = true; 
        }

        public int GetStage()       // 스테이지 반환
        {
            return stage;
        }

        public bool GetGameOVer()   // 게임오버 반환
        {
            return gameover;
        }
    }
}