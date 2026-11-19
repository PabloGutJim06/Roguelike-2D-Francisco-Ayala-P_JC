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
    #endregion

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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = moveAction.action.ReadValue<Vector2>();

        movimiento = movimiento.normalized;

        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}
