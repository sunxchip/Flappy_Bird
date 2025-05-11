using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 2f;
    public float rotateSpeed = 10f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }

        transform.rotation = Quaternion.Euler(0,0,rb.linearVelocity.y* rotateSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        GameManager.Instance.GameOver();
    
    }
}
