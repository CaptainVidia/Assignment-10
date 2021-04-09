using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < PoolManager.Instance.bulletList.Count; i++)
            {
                if (PoolManager.Instance.bulletList[i].activeInHierarchy == false)
                {
                    PoolManager.Instance.bulletList[i].SetActive(true);
                    PoolManager.Instance.bulletList[i].transform.position = Vector3.zero;
                    break;
                }
            }
            
        }
    }
}
