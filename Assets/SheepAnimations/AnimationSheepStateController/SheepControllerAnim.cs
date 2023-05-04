using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepControllerAnim : MonoBehaviour
{
    private Animator animator;
    int IsChangingColorHash;
    int IsScalingUpHash;
    int IsFloatingHash;
    int IsSpinningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        IsSpinningHash = Animator.StringToHash("IsSpinning");
        IsChangingColorHash = Animator.StringToHash("IsChangingColor");
        IsScalingUpHash = Animator.StringToHash("IsScaling");
        IsFloatingHash = Animator.StringToHash("IsFloating");
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool SpinSheep = animator.GetBool(IsSpinningHash);
        bool IsVtol = animator.GetBool(IsFloatingHash);
        bool IsScalingUp = animator.GetBool(IsScalingUpHash);
        bool IsChangingColor = animator.GetBool(IsChangingColorHash);
        bool fowardPressed = Input.GetKey("w");
        bool LeftPressed = Input.GetKey("a");
        bool RightPressed = Input.GetKey("d");
        bool DownPressed = Input.GetKey("s");

       if (!IsChangingColor && fowardPressed)
        {
            animator.SetBool(IsChangingColorHash, true);
        }
        if (IsChangingColor && !fowardPressed)
        {
            animator.SetBool(IsChangingColorHash, false);
        }
        if (!IsScalingUp && LeftPressed)
        {
            animator.SetBool(IsScalingUpHash, true);
        }
        if(IsScalingUp && LeftPressed)
        {
            animator.SetBool(IsScalingUpHash, false);
        }
        if(!IsVtol && RightPressed)
        {
            animator.SetBool(IsFloatingHash, true);
        }
        if(IsVtol && !RightPressed)
        {
            animator.SetBool(IsFloatingHash, false);
        }
        if(!SpinSheep && !DownPressed)
        {
            animator.SetBool(IsSpinningHash, true);
        }
        if(SpinSheep && !DownPressed)
        {
            animator.SetBool(IsSpinningHash, false);
        }

    }
}
