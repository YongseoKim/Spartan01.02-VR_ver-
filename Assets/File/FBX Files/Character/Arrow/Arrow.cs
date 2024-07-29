using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody arrowRigidbody;

    void Start()
    {
        // Rigidbody 컴포넌트를 가져옵니다.
        arrowRigidbody = GetComponent<Rigidbody>();

        // 4초 후에 화살을 비활성화하는 메서드 호출
        Invoke("DestroyArrow", 3.2f);
    }

    public void Shoot(Vector3 direction)
    {
        // 화살의 초기 위치와 회전 설정 (필요한 경우)
        transform.position = transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }

    void Update()
    {
        // 화살의 속도가 0이 아닌 경우 방향 업데이트
        if (arrowRigidbody.velocity != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(arrowRigidbody.velocity);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 충돌 시 로직
        // Debug.Log("화살이 충돌했습니다: " + collision.gameObject.name);

        // Shield 태그가 달린 게임 오브젝트와 충돌했을 때
        if (collision.gameObject.CompareTag("Shield"))
        {
            // 화살 게임 오브젝트를 비활성화
            gameObject.SetActive(false);
        }
    }

    void DestroyArrow()
    {
        // 화살 게임 오브젝트를 제거
        Destroy(gameObject);
    }
}
