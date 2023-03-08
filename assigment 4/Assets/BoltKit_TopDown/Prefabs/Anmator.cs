using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditorInternal.VersionControl.ListControl;

public class Anmator : MonoBehaviour
{
    // Start is called before the first frame update


    const string RIGHT = "WalkRight";
    const string LEFT = "WalkLeft";
    const string IDLE = "idle";

    float horizontal;
    float vertical;

    public string lastState;
    void ChangeAnimationState(string newState)
    {
        if (newState == lastState) return;

        Anim.Play(newState);

        lastState = newState;
        Debug.Log(newState);
    }



    Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");


        if (horizontal > 0) { ChangeAnimationState(RIGHT); }
        if (horizontal < 0) { ChangeAnimationState(LEFT); }
        if ((vertical > 0 || vertical < 0) && horizontal == 0) { ChangeAnimationState(RIGHT); }

        if (horizontal == 0 && vertical == 0) { ChangeAnimationState(IDLE); }

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Debug.Log(horizontal);
        Debug.Log(vertical);
    }
}
