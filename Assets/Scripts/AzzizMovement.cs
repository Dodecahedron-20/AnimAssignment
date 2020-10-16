using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzzizMovement : MonoBehaviour
{

    [SerializeField]
    private float Speed;
    [SerializeField]
    private float JumpSpeed;


    //All KeyCodes
    [SerializeField]
    private KeyCode Forward;
    [SerializeField]
    private KeyCode Backwards;
    [SerializeField]
    private KeyCode Jump;


    //Animations parts

    [SerializeField]
    private Animator Anim;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var horiz = 0;
        var vert = 0;

        if (Input.GetKey(Forward))
        {
            vert += 1;
            Anim.SetBool("Walk", true);
        }
        else
        {
            Anim.SetBool("Walk", false);
        }
        if (Input.GetKey(Backwards))
        {
            vert -= 1;
        }

        var movement = new Vector3(horiz, 0, vert).normalized * Speed * Time.deltaTime;
        transform.position += movement;


        if (Input.GetKey(Jump))
        {
            Anim.SetBool("Jump", true);
            
        }
        else
        {
            Anim.SetBool("Jump", false);
        }


    }

   



    




}
