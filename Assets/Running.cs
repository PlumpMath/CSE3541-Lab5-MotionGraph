using UnityEngine;
using System.Collections;

public class Running : MonoBehaviour {

    Animator runAnimator;
    bool waving = false;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        runAnimator = GetComponent<Animator>();

        float speed = Input.GetAxis("Vertical");
        float direction = Input.GetAxis("Horizontal");


        if (speed > 0.0f)
        {
            waving = false;
            runAnimator.SetBool("waving", waving);
        }


        runAnimator.SetFloat("speed", speed);
        runAnimator.SetFloat("Direction", direction, 0.25f, Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            runAnimator.SetTrigger("jump");
        }


        if (Input.GetKeyDown("1"))
        {
            runAnimator.SetTrigger("die");
        }

        if (Input.GetKeyDown("2"))
        {
            runAnimator.SetTrigger("revive");
        }

        if (Input.GetKeyDown("3"))
        {
            waving = !waving;

            runAnimator.SetBool("waving", waving);
        }




    }
}
