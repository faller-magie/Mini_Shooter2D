using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private GameObject bullet;

    private Shooter inputs;
    private Rigidbody2D corps;
    private Vector2 direction;


    // Start is called before the first frame update
    void Start()
    {
        inputs = new Shooter();
        inputs.Enable();
        inputs.Player.Move.performed += OnMovePerfomed;
        inputs.Player.Move.canceled += OnMoveCanceled;
        inputs.Player.Shoot.performed += OnShootPerformed;
        corps = GetComponent<Rigidbody2D>();

    }

    //La physique de deplacement du joueur, géré par unity
    private void FixedUpdate()
    {
        var horizontalPosition = new Vector2(transform.position.x,0);
        var verticalPosition = new Vector2(0,transform.position.y);
        direction = horizontalPosition - verticalPosition;
    }

    void update()
    {

    }

    //Quand le joueur appuye sur la touche de deplacement
    private void OnMovePerfomed(InputAction.CallbackContext obj)
    {
        Debug.Log("Move en marche");
        direction = obj.ReadValue<Vector2>();
    }

    //Quand le joueur n'appuie PAS sur la touche de deplacement
    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
        Debug.Log("Statue");
        direction = Vector2.zero; //notre variable à pour valeur 0 donc ça bouge pas..
    }

    private void OnShootPerformed(InputAction.CallbackContext obj)
    {
        // On instantie la balle du pistolet à la position du joueur avec une rotation nulle
        Instantiate(bullet,transform.position, Quaternion.identity);
    }
}
