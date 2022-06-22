using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private void Update() 
    {
        if(CompareTag("Player1"))
        {    
            if(Input.GetKey(KeyCode.W))
            {
                _direction = Vector2.up;
            }  
            else if(Input.GetKey(KeyCode.S))  
            {
                _direction = Vector2.down;
            }
            else
            {
                _direction = Vector2.zero;
            }
        }

        if(CompareTag("Player2"))
        {    
            if(Input.GetKey(KeyCode.UpArrow))
            {
                _direction = Vector2.up;
            }  
            else if(Input.GetKey(KeyCode.DownArrow))  
            {
                _direction = Vector2.down;
            }
            else
            {
                _direction = Vector2.zero;
            }
        }
    }

    private void FixedUpdate() 
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }
}
