using UnityEngine;

public class WarcraftCameraController : MonoBehaviour
{
    public Transform player; // Assign your player's transform here in the inspector
    public Vector3 cameraOffset; // Set the desired offset of the camera from the player
    public float movementSpeed = 5.0f; // Speed at which the player moves

    private void Start()
    {
        // Position the camera on start
        transform.position = player.position + cameraOffset;
    }

    private void Update()
    {
        // Follow the player with the camera
        transform.position = player.position + cameraOffset;

        // Player movement (this can be modified to suit your game's needs)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        // Move the player
        player.Translate(movementDirection * movementSpeed * Time.deltaTime, Space.World);
    }
}
