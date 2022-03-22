using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public  GameObject elvis;
    public static GameObject elvisPublic;
    public static float Speed = 2;
    public static float lrSpeed = 2;

    // jump
    public AudioSource jumpFX;
    public AudioSource runFX;
    public static float distance = 0;
    public float change = 100;
    public float temp = 0;
    public CharacterController characterController;
    private Vector3 velocity;
    public float jump = 6f;
    public float Gravity = -9.8f;
    public Animator elvisAnimated;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        elvisPublic = elvis;
        lrSpeed = 2;
        distance = 0;
        change = 25;
        temp = lrSpeed;
    }

    void levelUp()
    {
        distance = this.gameObject.transform.position.z;
        if (distance >=  change)
        {
            change += 25;
            if (lrSpeed <= 2.3)
            {
                lrSpeed += 0.1f;
            }
            else
            {
                lrSpeed = 2;
            }

        }
        print("Distance : " + distance+"    speed:  "+lrSpeed);
        
        
    }
    // Update is called once per frame
    void Update()
    {
        elvis = elvisPublic;
        
        float vertical =   Speed;
        float horizontal=0;
        levelUp();
          if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
          {
              if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
              {
                  horizontal = Input.GetAxis("Horizontal") * lrSpeed;
                elvisAnimated.SetBool("crashed", false);
                Speed = lrSpeed;
            }
          }
          if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
          {
              if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
              {
                   horizontal = Input.GetAxis("Horizontal") * lrSpeed;
                elvisAnimated.SetBool("crashed", false);
                Speed = lrSpeed;
            }
          }
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(move * Speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump"))
        {
            if (this.gameObject.transform.position.y < 2) {
                runFX.Stop();
                elvisAnimated.SetBool("aired", true);
                elvisAnimated.SetBool("crashed", false);
                velocity.y = jump;
                jumpFX.Play();
            }
           

        }else
        {
           
            velocity.y += Gravity * Time.deltaTime;
            elvisAnimated.SetBool("aired", false);
            runFX.Play();

        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
             temp = lrSpeed;
            lrSpeed = 1.5f;
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            lrSpeed = temp;
        }
        characterController.Move(velocity * Time.deltaTime);
    }
}

