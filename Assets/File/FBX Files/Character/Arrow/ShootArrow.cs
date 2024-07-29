using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrowPrefab; // ȭ�� �������� �Ҵ��ϼ���
    public Transform spawner; // ȭ���� �߻��� ��ġ(Spawner)�� �Ҵ��ϼ���
    public float launchForce = 500f; // �߻��ϴ� ��
    public float spawnDelay = 2f; // �߻� �����̸� public ������ ����

    void Start()
    {
        StartCoroutine(SpawnArrowAfterDelay(spawnDelay)); // ������ ������ �Ŀ� ȭ���� �߻��ϴ� �ڷ�ƾ�� ����
    }

    IEnumerator SpawnArrowAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // ������ �ð� ���� ���
        SpawnArrow(); // ȭ���� �߻�
    }

    void SpawnArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, spawner.position, spawner.rotation); // ȭ���� ����
        Rigidbody rb = arrow.GetComponent<Rigidbody>(); // ȭ���� Rigidbody�� ������
        if (rb != null)
        {
            rb.AddForce(spawner.forward * launchForce); // ȭ�쿡 ���� ����
        }
    }
}
