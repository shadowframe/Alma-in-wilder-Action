using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAlma : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public Animator animator;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement * Time.deltaTime;
  
    }
}
