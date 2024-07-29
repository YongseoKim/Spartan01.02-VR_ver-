using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersianWave : MonoBehaviour
{
    public GameObject wavePrefab; // Wave 게임오브젝트 프리팹
    public float createDelay = 3f; // 생성 지연 시간
    public float destroyDelay = 20f; // 제거 지연 시간

    private GameObject waveInstance; // 생성된 Wave 게임오브젝트 인스턴스

    void Start()
    {
        // Wave 게임오브젝트를 비활성화 상태로 생성
        waveInstance = Instantiate(wavePrefab, transform.position, Quaternion.identity);
        waveInstance.SetActive(false);

        // 지정된 시간 후에 CreateWave 메서드 호출
        Invoke("ActivateWave", createDelay);
    }

    void ActivateWave()
    {
        // Wave 게임오브젝트를 활성화
        waveInstance.SetActive(true);

        // 지정된 시간 후에 waveInstance 게임오브젝트 제거
        Destroy(waveInstance, destroyDelay);
    }
}
