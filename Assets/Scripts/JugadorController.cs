using UnityEngine;
using UnityEngine.InputSystem;     

public class JugadorController : MonoBehaviour
{
    #region Variables Serializadas
    [SerializeField] private InputActionProperty moveAction;
    [SerializeField] private InputActionProperty ataqueBasico1;
    [SerializeField] private InputActionProperty ataqueBasico2;
    [SerializeField] private float velocidad = 5.0f;
    #endregion

    #region Variables
    private Vector2 movimiento;
    private Rigidbody2D rb;
    #endregion

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        moveAction.action.Enable();
        ataqueBasico1.action.Enable();
        ataqueBasico2.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
        ataqueBasico1.action.Disable();
        ataqueBasico2.action.Disable();     
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = moveAction.action.ReadValue<Vector2>();

        movimiento = movimiento.normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.deltaTime);
    }
}
