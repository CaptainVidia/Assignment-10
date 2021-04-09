using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private static PoolManager _instance;
    public static PoolManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("PoolManager");
            }
            return _instance;
        }
    }
    public GameObject bulletPrefab;
    public GameObject bulletContainer;
    public int bulletsToSpawn = 20;
    public List<GameObject> bulletList = new List<GameObject>();
    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        for (int i = 0; i < bulletsToSpawn; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            bullet.transform.parent = bulletContainer.transform;
            bullet.SetActive(false);
            bulletList.Add(bullet);
        }
    }
}
