using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrowPrefab; // 화살 프리팹을 할당하세요
    public Transform spawner; // 화살을 발사할 위치(Spawner)를 할당하세요
    public float launchForce = 500f; // 발사하는 힘
    public float spawnDelay = 2f; // 발사 딜레이를 public 변수로 설정

    void Start()
    {
        StartCoroutine(SpawnArrowAfterDelay(spawnDelay)); // 지정된 딜레이 후에 화살을 발사하는 코루틴을 시작
    }

    IEnumerator SpawnArrowAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // 지정된 시간 동안 대기
        SpawnArrow(); // 화살을 발사
    }

    void SpawnArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, spawner.position, spawner.rotation); // 화살을 생성
        Rigidbody rb = arrow.GetComponent<Rigidbody>(); // 화살의 Rigidbody를 가져옴
        if (rb != null)
        {
            rb.AddForce(spawner.forward * launchForce); // 화살에 힘을 가함
        }
    }
}
