using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class TopDownAnimator : MonoBehaviour
{
    public GameObject player;
    public GameObject characterRenderer1;
    public GameObject characterRenderer2;

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
        
        if (player.GetComponentInChildren<SpriteRenderer>().sprite == characterRenderer1.GetComponent<SpriteRenderer>().sprite)
        {
            anim.SetBool("isChanged", false) ;
        }
        else if (player.GetComponentInChildren<SpriteRenderer>().sprite == characterRenderer2.GetComponent<SpriteRenderer>().sprite)
        {
            anim.SetBool("isChanged", true);
        }
    }
}