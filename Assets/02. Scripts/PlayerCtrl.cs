using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {
	private float h = 0.0f;
	private float v = 0.0f;

	//접근 필요한 컴포넌트는 변수에 할당
	private Transform tr;

	//이동 속도 변수
	public float moveSpeed = 10.0f;

    //회전 속도 변수 
    public float rotSpeed = 100.0f;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
    }
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxisRaw("Horizontal");
		v = Input.GetAxisRaw ("Vertical");

		Debug.Log("H=" + h.ToString());
		Debug.Log("V=" + v.ToString());

        //전후좌우 이동방향 벡터 계산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //Translate(이동방향*속도*변위값*Time.deltaTime, 기준좌표)
        tr.Translate(moveDir.normalized * moveSpeed  * Time.deltaTime, Space.Self);

        //Vector3.up축을 기준으로 rotSpeed만큼의 속도로 회전
        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));

	}
}
