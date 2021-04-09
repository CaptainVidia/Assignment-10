using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    void OnEnable()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 10);
        if (transform.position.y > 10)
        {
            OnDisable();
        }
    }
    void OnDisable()
    {
        this.gameObject.SetActive(false);
    }
}
