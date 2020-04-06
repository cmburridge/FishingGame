using System; 
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Movement : MonoBehaviour 
{ 
 
    public float moveSpeed = 5f;

    
    public Rigidbody2D rb; 
    public Animator animator; 
	 
    private Vector2 movement; 
 
    private void Update()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical"); 
		 
        animator.SetFloat("Horizontal", movement.x); 
        animator.SetFloat("Vertical", movement.y); 
        animator.SetFloat("Speed", movement.sqrMagnitude); 
        
        if (Input.GetButtonDown("Fire1"))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            rb.constraints = 0;
        }

    }
    

    private void FixedUpdate() 
    { 
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 
    } 
}