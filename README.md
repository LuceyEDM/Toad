# Toad
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    Transform player;
    Animator Main_Animator;
    public bool player_jump, player_run, player_idle;
    float movespeed;
    float jumpforce = 50f;
    Rigidbody2D rig;
     bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        Main_Animator = player.GetComponent<Animator>();
        movespeed = 10f;
        rig = gameObject.GetComponent<Rigidbody2D>();


    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (player_jump == false)
            {
                player_jump = true;

                rig.AddForce(transform.up * jumpforce);

            }
        } }
        // Update is called once per frame
        void Update()
        {
            Main_Animator.SetBool("player-jump", player_jump);
            Main_Animator.SetBool("player-run", player_run);
            Main_Animator.SetBool("player-idle", player_idle);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player.eulerAngles = new Vector3(0, 180, 0);
                player.Translate(movespeed * Time.deltaTime, 0, 0);
                player_run = true;
                player_idle = false;
            }
            if (Input.GetKey(KeyCode.RightArrow))//xia
            {
                player.eulerAngles = Vector3.zero;
                player.Translate(movespeed * Time.deltaTime, 0, 0);
                player_idle = false;
                player_run = true;
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {

                player_run = false;
                player_idle = true;

            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                player_idle = true;
                player_jump = false;
            }

        }
        void OnCollisionEnter2D(Collision2D collision)
        {


        grounded = true;

        }
    }


