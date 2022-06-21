using UnityEngine;

public class BounsySurface : MonoBehaviour
{
    [SerializeField]
    private float bounceStrenght;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Ball ball = other.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            Vector2 normal = other.GetContact(0).normal;
            ball.AddForce(-normal * bounceStrenght);
        }
    }
}
