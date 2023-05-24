using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    public GameObject bulletPref;
    public Transform handTransform;
    public float bulletOffsetScale = 1.5f;
    private List<GameObject> bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            // 发射炮弹
            GameObject newBullet = Instantiate(bulletPref, handTransform.position + Vector3.right * GetComponent<PlayerMoverment>().transform.localScale.x * bulletOffsetScale, handTransform.rotation);
            newBullet.SetActive(true);
            newBullet.GetComponent<BulletFly>().direction = GetComponent<PlayerMoverment>().transform.localScale.x;
            //newBullet.layer = LayerMask.NameToLayer("FG");
            //newBullet.transform.parent = transform;
        } else if (Input.GetKeyDown(KeyCode.Tab)) {
            Vector2 force = Quaternion.Euler(new Vector3(0f, 0f, 45f)) * Vector2.up * 10;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(50f,50f) * 10, ForceMode2D.Force);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
