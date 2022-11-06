using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        // handle animation
        if (anim != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Swing");
            }
        }
    }
    // destroy tag enemy if collided
    private void OnCollisionEnter2D(Collision2D creature)
    {
        if (creature.gameObject.tag == "Enemy")
        {
            Destroy(creature.gameObject);
        }
    }
}
