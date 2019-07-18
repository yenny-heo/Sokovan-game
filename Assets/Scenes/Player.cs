using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 10f;
    private Rigidbody playerRigidbody;

    // 게임이 처음 시작되었을 때 한번 실행됨
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();// 리지드 바디 컴포넌트 연결
    }

    // 화면이 한번 깜빡일 때 한번 실행됨
    void Update()
    {
        if(gameManager.isGameOver == true)
        {
            return;
        }
        // A <-          -> D
        // -1.0     0    +1.0
        //조이스틱의 아날로그버튼 때문에 숫자로 받아온다.
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        playerRigidbody.velocity = new Vector3 (inputX * speed, fallSpeed, inputZ * speed) ;
    }
}
