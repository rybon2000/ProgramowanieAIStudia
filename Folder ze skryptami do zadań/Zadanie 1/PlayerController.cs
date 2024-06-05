using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;

    private float movementSpeed = 3f;

    private float horizontal;
    private float vertical;

    private float currentHeigh;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        horizontal = Input.GetAxis("Horizontal") * movementSpeed;
        vertical = Input.GetAxis("Vertical") * movementSpeed;

        Vector3 move = new Vector3(horizontal, currentHeigh, vertical);
        characterController.Move(move * Time.deltaTime);
    }
}
