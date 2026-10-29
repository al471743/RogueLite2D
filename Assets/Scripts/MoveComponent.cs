using UnityEngine;
using UnityEngine.InputSystem;

public class MoveComponent : MonoBehaviour
{
    
    //TODO: Cambiar Input actions a inyección de dependencias.
    private PlayerIActions _playerActions;

    
    
    //Suscribir la acción a valor de mapa de acciones (Vector2 Movimiento)
    InputAction move => _playerActions.Player.Move;
   

    [SerializeField] private int speed;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerActions = new PlayerIActions();
        _playerActions.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(move.ReadValue<Vector2>() * (speed * Time.deltaTime));

    }
    
    
    
    
}
