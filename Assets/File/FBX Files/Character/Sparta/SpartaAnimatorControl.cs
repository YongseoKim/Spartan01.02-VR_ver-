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
        // 오른쪽 컨트롤러의 x 버튼 클릭
        if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool isPressed) && isPressed)
        {
            anim.SetTrigger("Block");
        }

        // 오른쪽 컨트롤러의 y 버튼 클릭
        if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool isPressedSecondary) && isPressedSecondary)
        {
            anim.SetTrigger("Slash");
        }

        // 오른쪽 컨트롤러의 그립 버튼 클릭
        if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool isPressedGrip) && isPressedGrip)
        {
            anim.SetTrigger("Idle");
        }
    }
}
