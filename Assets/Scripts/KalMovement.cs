using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KalMovement : MonoBehaviour
{

    [SerializeField]
    private float Speed;

    [SerializeField]
    private KeyCode SideAttack;
    [SerializeField]
    private KeyCode MoveRight;



    //Animation things
    [SerializeField]
    private Animator Anim;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move Right things;

        var horiz = 0;

        if (Input.GetKeyDown(MoveRight))
        {
            horiz += 1;
        }

        var movement = new Vector3(horiz, 0, 0).normalized * Speed * Time.deltaTime;
        transform.position += movement;




        //Side attack things


        if (Input.GetKeyDown(SideAttack))
        {
            Anim.SetBool("Attk1", true);
        }
        else
        {
            Anim.SetBool("Attk1", false);
        }
    }
}
