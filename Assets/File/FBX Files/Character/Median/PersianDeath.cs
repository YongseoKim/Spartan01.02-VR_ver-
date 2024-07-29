using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersianDeath : MonoBehaviour
{
    public int collisionCount = 0;
    public int maxCollisions = 3;
    public GameObject Persian; // ��Ȱ��ȭ�� ���� ������Ʈ
    private Animator animator;
    private bool isDeathTriggered = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
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
