
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    PlayerInput playerInput;
    TankController tank;
    public PlayerPref TouchInput;
    public bool touched = false;
    public bool touched2 = false;
    void OnEnable()
    {
        if (TouchInput != null)
            TouchInput.Enable();

    }
    void OnDisable()
    {
        if (TouchInput != null)
            TouchInput.Disable();
    }
    void Awake()
    {
        TouchInput = new PlayerPref();
    }

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        tank = GameObject.Find("Tank").GetComponent<TankController>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector2 moveFixed = playerInput.actions["Move"].ReadValue<Vector2>();
        Vector2 lookFixed = playerInput.actions["Look"].ReadValue<Vector2>();
        float inputAngle = Mathf.Atan2(moveFixed.y, moveFixed.x) * Mathf.Rad2Deg;
        float inputAngle2 = Mathf.Atan2(lookFixed.y, lookFixed.x) * Mathf.Rad2Deg;
        tank.MoveTankObject(Mathf.Abs(moveFixed.x), Mathf.Abs(moveFixed.y));
        tank.RotateTank(inputAngle);
        tank.RotateWheels(moveFixed.x, moveFixed.y);
        tank.RotateBarrel(inputAngle2);

    }
}