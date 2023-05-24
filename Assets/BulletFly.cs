using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    public float speed = 5.0f;
    public LayerMask mask;

    public float direction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print($"OnTriggerEnter2D: {collision.gameObject.layer}");
        print($"{LayerMask.NameToLayer("Ground")}");
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground")
            || collision.gameObject.layer == LayerMask.NameToLayer("Trap"))
        {
            Destroy(gameObject, 0);
        }
    }

    private void FixedUpdate()
    {
        if (direction < 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        } else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
