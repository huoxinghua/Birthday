using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerSO playerSO;

    private Vector2 _movement;
    private float _rotate;
    private float balancePos;
    private TrayBalance _balance;
    private CharacterController character;
    private GroundCheck _groundCheck;

   

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        _groundCheck = GetComponent<GroundCheck>();
    }

    private void Start()
    {
        _balance = GetComponentInChildren<TrayBalance>();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        MovementHandler();
        RotateHandler();
        BalanceCakeHandler();
    }

    private void MovementHandler()
    {
        Vector3 moveDir = transform.forward * _movement.y + transform.right * _movement.x;
        moveDir.Normalize();
        moveDir.y = 0f;

            character.SimpleMove(moveDir * playerSO.playerSpeed * Time.deltaTime);
    }

    private void RotateHandler()
    {
        if (_rotate < 0f)
            transform.Rotate(0f, -playerSO.RotateSpeed, 0f);

        else if (_rotate > 0f)
            transform.Rotate(0f, playerSO.RotateSpeed, 0f);
    }

    public void MovementInput(Vector2 input)
    {
        _movement = input;
    }

    public void RotateInput(float value)
    {
        _rotate = value;
    }

    private void BalanceCakeHandler()
    {
        float angleZ = balancePos * 15f;
        _balance.TrayRotation(transform ,angleZ, playerSO.balanceSpeed);
    }

    public void BalanceInput(Vector2 mouse)
    {
        balancePos = (mouse.x - (Screen.width / 2)) / (Screen.width / 2);
    }
}
