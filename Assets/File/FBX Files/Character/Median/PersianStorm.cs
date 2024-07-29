using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersianStorm : MonoBehaviour
{
    // 이동할 거리
    public float distance = 10f;
    // 이동할 시간
    public float duration = 10f;

    // 시작 위치
    private Vector3 startPosition;
    // 타이머
    private float timer = 0f;

    void Start()
    {
        // 시작 위치를 저장
        startPosition = transform.position;
    }

    void Update()
    {
        // 시간이 경과함에 따라 타이머를 증가
        timer += Time.deltaTime;
        // 타이머가 duration을 넘지 않도록 클램프
        timer = Mathf.Clamp(timer, 0, duration);

        // 현재 위치를 선형 보간하여 계산
        float t = timer / duration;
        Vector3 newPosition = startPosition + transform.forward * distance * t;

        // 오브젝트의 위치를 업데이트
        transform.position = newPosition;
    }
}
