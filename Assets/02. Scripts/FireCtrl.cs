using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    //총알 프리팹
    public GameObject bullet;
    //총알 발사 좌표
    public Transform firePos;

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 버튼 클릭시 Fire 함수 호출
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        //동적으로 총알 생성해주는 함수
        CreateBullet();
    }

    void CreateBullet()
    {
        //Bullet 프리팹을 동적으로 생성
        Instantiate(bullet, firePos.position, firePos.rotation);
    }
}
