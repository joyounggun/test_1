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
        if (Input.GetMouseButtonDown(0)) //���콺 ���� �Է� �Ǿ��� �� ����
        {
            hp -= 10; //Hp = Hp - 10
            if (hp <= 0) //ä���� 0���ϰ� �Ǹ� �ı��Ѵ�
            {
                Destroy(gameObject); //gemaObject�� ��ũ��Ʈ�� �پ��ִ� ������Ʈ ��Ī
            }
        }

    }
}