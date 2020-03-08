using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventure_Kid : MonoBehaviour
{
    [SerializeField] float STD_MOVE_SPEED = 0.01f;
    Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        //animation.Play();  // Debug animation playing
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        Vector3 movement = new Vector3(0,0,0);
        if(Input.GetKey(KeyCode.W))
        {
            movement += new Vector3(STD_MOVE_SPEED, 0, 0); //todo Apply rotation
        }
        if(Input.GetKey(KeyCode.S))
        {
            movement += new Vector3(-STD_MOVE_SPEED, 0, 0); //todo Apply Rotation
        }

        if(Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(0, 0, STD_MOVE_SPEED); //Todo apply rotation
        }
        if(Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(0, 0, -STD_MOVE_SPEED); //Todo Apply Rotation
        }

        if(movement.magnitude > STD_MOVE_SPEED)
        {
            movement.Normalize();
            movement *= STD_MOVE_SPEED;
        }
        if ((movement.magnitude > 0) && !(animation.isPlaying))
        {
            animation.Play();
        }
        else if (movement.magnitude <=0)
        {
            animation.Stop();
        }

        transform.position += movement;
    }
}
