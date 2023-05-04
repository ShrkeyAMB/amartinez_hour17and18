using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepInputs : MonoBehaviour
{
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Anim.SetBool("speed", Input.GetKeyDown(KeyCode.A));
    }
}
