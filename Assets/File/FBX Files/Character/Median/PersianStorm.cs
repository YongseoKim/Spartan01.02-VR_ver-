using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersianStorm : MonoBehaviour
{
    // �̵��� �Ÿ�
    public float distance = 10f;
    // �̵��� �ð�
    public float duration = 10f;

    // ���� ��ġ
    private Vector3 startPosition;
    // Ÿ�̸�
    private float timer = 0f;

    void Start()
    {
        // ���� ��ġ�� ����
        startPosition = transform.position;
    }

    void Update()
    {
        // �ð��� ����Կ� ���� Ÿ�̸Ӹ� ����
        timer += Time.deltaTime;
        // Ÿ�̸Ӱ� duration�� ���� �ʵ��� Ŭ����
        timer = Mathf.Clamp(timer, 0, duration);

        // ���� ��ġ�� ���� �����Ͽ� ���
        float t = timer / duration;
        Vector3 newPosition = startPosition + transform.forward * distance * t;

        // ������Ʈ�� ��ġ�� ������Ʈ
        transform.position = newPosition;
    }
}
