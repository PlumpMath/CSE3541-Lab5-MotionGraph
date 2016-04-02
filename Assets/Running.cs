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

        float vert = Input.GetAxis("Vertical");

        runAnimator.SetFloat("speed", vert);

        Debug.Log(vert);
    }
}
