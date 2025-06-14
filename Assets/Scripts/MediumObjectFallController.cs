using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumObjectFallController : MonoBehaviour
{
    float wait = 0.1f;
    public GameObject fallingObject;
    float fallSpeed = 1f;
    void Start()
    {
        InvokeRepeating("Fall", wait, wait);
    }

    void Fall()
    {
        GameObject obj = Instantiate(fallingObject, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.gravityScale = fallSpeed;
            rb.drag = 0;        // 加入這行，設定空氣阻力為0
        }
    }
}
