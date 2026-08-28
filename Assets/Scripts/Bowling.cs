using UnityEngine;
using UnityEngine.InputSystem;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int ForcePower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();

        if (Keyboard.current.rightArrowKey.isPressed
            || Keyboard.current.dKey.isPressed)
            Moveright();


        if (Keyboard.current.leftArrowKey.isPressed
            || Keyboard.current.aKey.isPressed)
            Moveleft();
    }

    public void ShootBall()
    {
        rb.AddForce(Vector3.forward * ForcePower, ForceMode.Impulse);
    }

    private void Moveright()
    {
        transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
    }

    private void Moveleft()
    {
        transform.position += new Vector3(-1f, 0f, 0f) * Time.deltaTime;
    }
}
