using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;

    private Shooter inputs;
    private Rigidbody2D corps;
    private Vector2 direction;


    private void OnEnable()
    {
        inputs = new Shooter();
        inputs.Enable();
        inputs.Player.Move.performed += OnMovePerfomed;
        inputs.Player.Move.canceled += OnMoveCanceled;
    }

    private void OnMovePerfomed(InputAction.CallbackContext obj)
    {
        Debug.Log("Move en marche");
        direction = obj.ReadValue<Vector2>();
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
        Debug.Log("Statue");
        direction = Vector2.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }
}
