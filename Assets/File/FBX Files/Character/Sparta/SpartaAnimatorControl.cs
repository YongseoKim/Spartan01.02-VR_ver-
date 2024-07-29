using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class SpartaAnimatorControl : MonoBehaviour
{
    public Animator anim;
    public XRController rightController;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ��Ʈ�ѷ��� x ��ư Ŭ��
        if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool isPressed) && isPressed)
        {
            anim.SetTrigger("Block");
        }

        // ������ ��Ʈ�ѷ��� y ��ư Ŭ��
        if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool isPressedSecondary) && isPressedSecondary)
        {
            anim.SetTrigger("Slash");
        }

        // ������ ��Ʈ�ѷ��� �׸� ��ư Ŭ��
        if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool isPressedGrip) && isPressedGrip)
        {
            anim.SetTrigger("Idle");
        }
    }
}
