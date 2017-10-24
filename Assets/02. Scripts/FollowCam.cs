using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

    public Transform targetTr; //추적할 타깃 게임 오브젝트의 Transform 변수
    public float dist = 5f; //카메라와의 일정 거리
    public float height = 4.0f; //카메라의 높이 설정
    public float damTrace = 60.0f; //부드러운 추적을 위한 변수

    //카메라 자신의 Transform 변수
    private Transform tr;

	// Use this for initialization
	void Start () {
        //카메라 자신의 Transfrom 컴포넌트를 tr에 할당
        tr = GetComponent<Transform>();
	}
	
	//타깃 이동 종료 후 카메라 추적하기 위해 LateUpdate
    void LateUpdate()
    {
        tr.position = Vector3.Lerp(tr.position, targetTr.position - (targetTr.forward * dist) + (Vector3.up * height), Time.deltaTime * damTrace);
        //카메라가 타깃 게임 오브젝트 바라보게 설정
        tr.LookAt(targetTr.position);
    }
}
