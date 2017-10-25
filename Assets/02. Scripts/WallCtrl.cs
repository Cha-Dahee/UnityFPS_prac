using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCtrl : MonoBehaviour {

	//충돌 시작에서 발생하는 이벤트
    void OnCollisionEnter(Collision coll)
    {
        //충돌 게임 오브젝트의 태그 값 비교
        if(coll.collider.tag == "BULLET")
        {
            //충돌 게임 오브젝트 삭제
            Destroy(coll.gameObject);
        }
    }
}
