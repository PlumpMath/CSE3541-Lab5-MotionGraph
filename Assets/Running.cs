using UnityEngine;
using System.Collections;

public class Running : MonoBehaviour {

    Animator runAnimator;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        runAnimator = GetComponent<Animator>();

        float speed = Input.GetAxis("Vertical");
        float direction = Input.GetAxis("Horizontal");
        Debug.Log(direction);

        runAnimator.SetFloat("speed", speed);
        runAnimator.SetFloat("Direction", direction, 0.25f, Time.deltaTime);
    }
}
