using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10f;
    protected Rigidbody2D _rigidbody;

    private void Start() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

     public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0);
        _rigidbody.velocity = Vector2.zero;
    }

}
