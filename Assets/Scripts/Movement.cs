using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}