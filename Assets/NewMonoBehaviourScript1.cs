
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float Speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);

        if (transform.position.x > 14.3f)
            transform.position = new Vector3(-14.3f, transform.position.y, transform.position.z);

        if (transform.position.x < -14.3f)
            transform.position = new Vector3(14.3f, transform.position.y, transform.position.z);
    }
}
