using UnityEngine;

public class movement : MonoBehaviour
{
 public float MovementSpeed = 1f;
 public float JumpForce = 1f;
 private Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)< 0.001f){
        _rigidbody.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
    }
    }
}
