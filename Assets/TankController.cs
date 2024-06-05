using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float moveSpeed = 5.00f;
    public float rotationSpeed = 120.00f;
    public GameObject[] leftWheels;
    public GameObject[] rightWheels;
    public float wheelRotationSpeed = 500.00f;
    private Rigidbody tank;
    private float moveInput;
    private float rotationInput;
    private float oldRotation;
    private float lastRotation;
    private float lastBarrelRotation;
    private Transform Barrel;
    private Quaternion BarrelInitialRotation;
    private Vector3 TankUIContainerInitialRotation;
    Quaternion startRotation;
    Quaternion endRotation;
    Quaternion startBarrelRotation;
    Quaternion endBarrelRotation;
    Transform TankUIContainerCanvas;
    // Start is called before the first frame update
    void Start()
    {
        tank = GetComponent<Rigidbody>();
        Barrel = transform.Find("Barrel");
        BarrelInitialRotation = Barrel.rotation;

        TankUIContainerCanvas = transform.Find("TankUIContainerCanvas");
        TankUIContainerInitialRotation = TankUIContainerCanvas.position;
    }

    void FixedUpdate()
    {

    }
    public void MoveTankObject(float inputX, float inputY)
    {
        float inputFactor = 0;
        if (inputX == 0 && inputY == 0)
        {
            inputFactor = 0;
        }
        inputFactor = inputX > inputY ? inputX : inputY;
        Vector3 moveDirection = -transform.forward * inputFactor * moveSpeed * Time.fixedDeltaTime;
        tank.MovePosition(tank.position + moveDirection);
        TankUIContainerCanvas.rotation = Quaternion.identity;
        TankUIContainerCanvas.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 15, gameObject.transform.position.z);
        //tank.velocity = transform.forward * 10.00f;
        // gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        // tank.velocity = transform.forward * 10.00f;
    }
    public void RotateTank(float input)
    {
        if (lastRotation != null && input != lastRotation && input == 0)
        {
            input = lastRotation;
        }
        lastRotation = input;
        startRotation = transform.rotation;
        endRotation = Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, -lastRotation, gameObject.transform.rotation.eulerAngles.z);
        gameObject.transform.rotation = Quaternion.Lerp(startRotation, endRotation, 0.20f);
        // gameObject.transform.eulerAngles = to;
        Barrel.rotation = BarrelInitialRotation;
        TankUIContainerCanvas.rotation = Quaternion.identity;
    }
    public void RotateBarrel(float input)
    {
        if (lastBarrelRotation != null && input != lastBarrelRotation && input == 0)
        {
            input = lastBarrelRotation;
        }
        lastBarrelRotation = input;
        startBarrelRotation = Barrel.transform.rotation;
        endBarrelRotation = Quaternion.Euler(Barrel.transform.rotation.eulerAngles.x, -lastBarrelRotation, Barrel.transform.rotation.eulerAngles.z);
        Barrel.transform.rotation = Quaternion.Lerp(startBarrelRotation, endBarrelRotation, 0.3f);
        BarrelInitialRotation = Barrel.rotation;
        // gameObject.transform.rotation = Quaternion.identity;
    }
    public void RotateWheels(float input, float rotationInput)
    {
        float wheelRotation = input * wheelRotationSpeed * Time.deltaTime;

        foreach (GameObject wheel in leftWheels)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(wheelRotation - rotationInput * wheelRotationSpeed * Time.deltaTime, 0f, 0f);
            }
        }
        foreach (GameObject wheel in rightWheels)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(wheelRotation + rotationInput * wheelRotationSpeed * Time.deltaTime, 0f, 0f);
            }
        }
    }

    void Update()
    {
    }
}
