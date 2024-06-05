using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour
{
    public float launchedSpeed = 75.0f;
    public GameObject objectPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnObject()
    {
        Vector3 spwanPosition = transform.position;
        Quaternion SpawnRotation = Quaternion.identity;

        Vector3 localXdirection = transform.TransformDirection(Vector3.forward);
        Vector3 velocity = -localXdirection * launchedSpeed;

        GameObject newObject = Instantiate(objectPrefab, spwanPosition, SpawnRotation);
        Rigidbody rb = newObject.GetComponent<Rigidbody>();

        rb.velocity = velocity;

    }
}
