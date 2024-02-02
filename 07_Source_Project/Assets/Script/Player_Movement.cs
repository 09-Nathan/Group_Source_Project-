using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5f;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    private Animator animator;
    // Start is called before the first frame update

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Left_Move", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Right_Move", true);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Left_Move", false);
            animator.SetBool("Right_Move", false);
        }
        // Call the movement function
        MovePlayer(horizontalInput, verticalInput);
    }

    void MovePlayer(float horizontalInput, float verticalInput)
    {
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);

        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);

        transform.position = new Vector2(clampedX, clampedY);
    }
}
