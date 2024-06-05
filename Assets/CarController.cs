using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    private float currentSteerAngle, currentbreakForce;
    private bool isBreaking;

    public GameObject Barrel;

    // Settings
    [SerializeField] private float motorForce, breakForce, maxSteerAngle;

    // Wheel Colliders
    [SerializeField] private WheelCollider frontLeftWheelCollider, frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider, rearRightWheelCollider;

    // Wheels
    [SerializeField] private Transform frontLeftWheelTransform, frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform, rearRightWheelTransform;
    void Awake()
    {
        frontLeftWheelCollider.ConfigureVehicleSubsteps(2, 10, 100);
        rearLeftWheelCollider.ConfigureVehicleSubsteps(2, 10, 100);
        frontRightWheelCollider.ConfigureVehicleSubsteps(2, 10, 100);
        rearRightWheelCollider.ConfigureVehicleSubsteps(2, 10, 100);
    }
    void Start()
    {
        Barrel = GameObject.Find("Barrel");
    }
    private void FixedUpdate()
    {
        // GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        isBreaking = verticalInput == 0 ? true : false;
    }

    private void GetInput()
    {
        // Steering Input
        horizontalInput = Input.GetAxis("Horizontal");

        // Acceleration Input
        verticalInput = Input.GetAxis("Vertical");

        // Breaking Input
        isBreaking = Input.GetKey(KeyCode.Space);
    }
    public void move(Vector2 move)
    {
        verticalInput = move.x;
        horizontalInput = move.y;
    }
    public void look(Vector2 look)
    {

        float degy = look.y * Mathf.Rad2Deg;
        float degx = look.x * Mathf.Rad2Deg;
        Quaternion target = Quaternion.Euler(0, degy * 5, 0);
        Quaternion target2 = Quaternion.Euler(0, degx * 5, 0);
        Debug.Log(target);

        // Barrel.transform.localRotation = Quaternion.RotateTowards(Barrel.transform.rotation, target, 2.00f);
        // Barrel.transform.localRotation = Quaternion.RotateTowards(Barrel.transform.rotation, target2, 2.00f); ;
        Barrel.transform.localRotation = target;
        // Barrel.transform.localRotation = target2;
    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = -(verticalInput * motorForce);
        frontRightWheelCollider.motorTorque = -(verticalInput * motorForce);
        currentbreakForce = isBreaking ? breakForce : 0f;
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = -(maxSteerAngle * horizontalInput);
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);

        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}