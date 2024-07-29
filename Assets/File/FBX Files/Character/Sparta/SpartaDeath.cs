using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpartaDeath : MonoBehaviour
{
    public int collisionCount = 0;
    public int maxCollisions = 50;
    public GameObject Persian; // 비활성화할 게임 오브젝트
    private Animator animator;
    private bool isDeathTriggered = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Longsword"))
        {
            collisionCount++;

            if (collisionCount >= maxCollisions && !isDeathTriggered)
            {
                isDeathTriggered = true;
                animator.SetTrigger("Death");
                StartCoroutine(DeactivatePersianAfterDelay(5.0f));
            }
        }
    }

    private IEnumerator DeactivatePersianAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (Persian != null)
        {
            Persian.SetActive(false);
        }
    }
}
