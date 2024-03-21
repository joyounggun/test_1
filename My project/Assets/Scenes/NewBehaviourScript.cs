using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public int hp = 100;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 왼쪽 입력 되었을 때 조건
        {
            hp -= 10; //Hp = Hp - 10
            if (hp <= 0) //채력이 0이하가 되면 파괴한다
            {
                Destroy(gameObject); //gemaObject는 스크립트가 붙어있는 오브잭트 지칭
            }
        }

    }
}