
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        transform.Translate(movement * speed * Time.deltaTime);

        if (transform.position.x > 14.3f)
            transform.position = new Vector3(-14.3f, transform.position.y, transform.position.z);

        if (transform.position.x < -14.3f)
            transform.position = new Vector3(14.3f, transform.position.y, transform.position.z);
    }
}

