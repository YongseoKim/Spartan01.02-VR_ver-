using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody arrowRigidbody;

    void Start()
    {
        // Rigidbody ������Ʈ�� �����ɴϴ�.
        arrowRigidbody = GetComponent<Rigidbody>();

        // 4�� �Ŀ� ȭ���� ��Ȱ��ȭ�ϴ� �޼��� ȣ��
        Invoke("DestroyArrow", 3.2f);
    }

    public void Shoot(Vector3 direction)
    {
        // ȭ���� �ʱ� ��ġ�� ȸ�� ���� (�ʿ��� ���)
        transform.position = transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }

    void Update()
    {
        // ȭ���� �ӵ��� 0�� �ƴ� ��� ���� ������Ʈ
        if (arrowRigidbody.velocity != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(arrowRigidbody.velocity);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �浹 �� ����
        // Debug.Log("ȭ���� �浹�߽��ϴ�: " + collision.gameObject.name);

        // Shield �±װ� �޸� ���� ������Ʈ�� �浹���� ��
        if (collision.gameObject.CompareTag("Shield"))
        {
            // ȭ�� ���� ������Ʈ�� ��Ȱ��ȭ
            gameObject.SetActive(false);
        }
    }

    void DestroyArrow()
    {
        // ȭ�� ���� ������Ʈ�� ����
        Destroy(gameObject);
    }
}
