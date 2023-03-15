using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public float speed = 200f;
    public new Rigidbody2D rigidbody { get; private set; }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.position = Vector2.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;

        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * speed);
    }

}