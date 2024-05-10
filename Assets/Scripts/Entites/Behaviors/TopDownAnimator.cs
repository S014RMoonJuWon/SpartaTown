using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class TopDownAnimator : MonoBehaviour
{
    private Rigidbody2D movementRigidbody;
    private Animator anim;

    private void Awake()
    {
        movementRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (movementRigidbody.velocity == Vector2.zero)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }
    }
}