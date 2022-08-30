using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public int rotationSpeed;
    public bool onfunction;
    public Vector3 rot_dir;
    public Vector3 rot_anchor;
    private int func_started;
    public bool checked_dir;
    public Transform xy, xny, nxy, nxny, yz, ynz, nyz, nynz, xz, xnz, nxz, nxnz;

    // Update is called once per frame
    void Update()
    {
        // checks if player is ready to move
        if (checked_dir == false && (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0))
        {
            checkdirection();
            checked_dir = true;
            func_started = 0;
        }
    }

    void move()
    {
        if(onfunction == true)
        {
            transform.RotateAround(rot_anchor, rot_dir, Time.fixedDeltaTime * rotationSpeed);
            func_started += 1;
            if (50*90/rotationSpeed == func_started )
            {
                onfunction = false;
                checked_dir = false;
            }
        }
        
    }

    private void FixedUpdate()
    {
        move();
    }


    void checkdirection()
    {
        if (transform.right == new Vector3(0f,1f,0f) || transform.right == new Vector3(0f,-1f,0f))
        {
            // X AXIS IS FACING UPWWARDS OR DOWNWARDS
            // Y Control
            if(transform.up == new Vector3(1f, 0f, 0f) || transform.up == new Vector3(-1f, 0f, 0f))
            {
                if(transform.right == new Vector3(0f, 1f, 0f) && transform.up == new Vector3(1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.right == new Vector3(0f, 1f, 0f) && transform.up == new Vector3(-1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.right == new Vector3(0f, -1f, 0f) && transform.up == new Vector3(1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.right == new Vector3(0f, -1f, 0f) && transform.up == new Vector3(-1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
            }

            // Z Control
            else if(transform.forward == new Vector3(1f, 0f, 0f) || transform.forward == new Vector3(-1f, 0f, 0f))
            {
                if(transform.right == new Vector3(0f, 1f, 0f) && transform.forward == new Vector3(1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.right == new Vector3(0f, 1f, 0f) && transform.forward == new Vector3(-1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.right == new Vector3(0f, -1f, 0f) && transform.forward == new Vector3(1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.right == new Vector3(0f, -1f, 0f) && transform.forward == new Vector3(-1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
            }
        }
        else if(transform.up == new Vector3(0f,1f,0f) || transform.up == new Vector3(0f,-1f,0f))
        {
            // Y AXIS IS FACING UPWARDS OR DOWWARDS
            // X control
            if(transform.right == new Vector3(1f,0f,0f) || transform.right == new Vector3(-1f, 0f, 0f))
            {
                if(transform.up == new Vector3(0f,1f,0f) && transform.right == new Vector3(1f,0f,0f))
                {
                    if(Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else if(Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.up == new Vector3(0, 1, 0) && transform.right == new Vector3(-1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if (transform.up == new Vector3(0, -1, 0) && transform.right == new Vector3(1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if (transform.up == new Vector3(0, -1, 0) && transform.right == new Vector3(-1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }

            }
            // Z control
            else if(transform.forward == new Vector3(1, 0, 0) || transform.forward == new Vector3(-1, 0, 0))
            {
                if (transform.up == new Vector3(0f, 1f, 0f) && transform.forward == new Vector3(1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.up == new Vector3(0f, 1f, 0f) && transform.forward == new Vector3(-1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = xny.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = nxny.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.up == new Vector3(0f, -1f, 0f) && transform.forward == new Vector3(1f, 0f, 0f))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.up == new Vector3(0f, -1f, 0f) && transform.forward == new Vector3(-1f, 0f, 0f))
                {
                    
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.forward;
                        rot_anchor = nxy.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.forward;
                        rot_anchor = xy.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
            }

        }
        else if(transform.forward == new Vector3(0,1,0) || transform.forward == new Vector3(0,-1,0))
        {
            // Z AXIS IS FACING UPWARDS OR DOWNWARDS
            // X Control
            if(transform.right == new Vector3(1,0,0) || transform.right == new Vector3(-1,0,0))
            {
                if(transform.forward == new Vector3(0,1,0) && transform.right == new Vector3(1,0,0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.forward == new Vector3(0, 1, 0) && transform.right == new Vector3(-1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.forward == new Vector3(0, -1, 0) && transform.right == new Vector3(1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if(transform.forward == new Vector3(0, -1, 0) && transform.right == new Vector3(-1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
            }
            // Y Control
            else if(transform.up == new Vector3(1,0,0) || transform.up == new Vector3(-1,0,0))
            {
                if (transform.forward == new Vector3(0, 1, 0) && transform.up == new Vector3(1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if (transform.forward == new Vector3(0, 1, 0) && transform.up == new Vector3(-1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = nynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = ynz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = nxnz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = xnz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if (transform.forward == new Vector3(0, -1, 0) && transform.up == new Vector3(1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
                else if (transform.forward == new Vector3(0, -1, 0) && transform.up == new Vector3(-1, 0, 0))
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        rot_dir = -transform.right;
                        rot_anchor = nyz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        rot_dir = transform.right;
                        rot_anchor = yz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") > 0)
                    {
                        rot_dir = -transform.up;
                        rot_anchor = xz.position;
                        onfunction = true;
                    }
                    else if (Input.GetAxisRaw("Vertical") < 0)
                    {
                        rot_dir = transform.up;
                        rot_anchor = nxz.position;
                        onfunction = true;
                    }
                    else
                    {
                        checked_dir = false;
                    }
                }
            }
        }
    }
}
