using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // ������Ʈ�� ó���� ����
    private Transform tr;
    // Animation ������Ʈ�� ������ ����
    private Animation anim;
    // �̵� �ӷ� ���� (public���� ����Ǿ� �ν����� �信 �����)
    public float moveSpeed = 10.0f;
    // ȸ�� �ӵ� ����
    public float turnSpeed = 80.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Transform ������Ʈ�� ������ ������ ����
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();
        anim.Play("Idle");
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ +1.0f
        float v = Input.GetAxis("Vertical"); // -1.0f ~ 0.0f ~ +1.0f
        float r = Input.GetAxis("Mouse X");
        Debug.Log("h=" + h);
        Debug.Log("v=" + v);
        // �����¿� �̵� ���� ���� ���
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        // Translate(�̵� ���� * �ӷ� * Time.deltaTime)
        tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);
        tr.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);
    }
}