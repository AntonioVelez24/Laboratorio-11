using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _Rigidbody2D;
    public float speed;
    public int xDirection;
    public int yDirection;
    private void Awake()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        _Rigidbody2D.velocity = new Vector2(speed * xDirection, speed * yDirection);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horizontal")
        {
            xDirection = xDirection*-1;
            
        }
        if (collision.gameObject.tag == "Vertical")
        {
            yDirection = yDirection*-1;
        }
    }
}
