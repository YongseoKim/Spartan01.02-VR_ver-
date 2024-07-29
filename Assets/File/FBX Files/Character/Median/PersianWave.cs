using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersianWave : MonoBehaviour
{
    public GameObject wavePrefab; // Wave ���ӿ�����Ʈ ������
    public float createDelay = 3f; // ���� ���� �ð�
    public float destroyDelay = 20f; // ���� ���� �ð�

    private GameObject waveInstance; // ������ Wave ���ӿ�����Ʈ �ν��Ͻ�

    void Start()
    {
        // Wave ���ӿ�����Ʈ�� ��Ȱ��ȭ ���·� ����
        waveInstance = Instantiate(wavePrefab, transform.position, Quaternion.identity);
        waveInstance.SetActive(false);

        // ������ �ð� �Ŀ� CreateWave �޼��� ȣ��
        Invoke("ActivateWave", createDelay);
    }

    void ActivateWave()
    {
        // Wave ���ӿ�����Ʈ�� Ȱ��ȭ
        waveInstance.SetActive(true);

        // ������ �ð� �Ŀ� waveInstance ���ӿ�����Ʈ ����
        Destroy(waveInstance, destroyDelay);
    }
}
