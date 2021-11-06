using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speedMove;
    public float jumpPower;

    private float gravityForce; // гравитация персонажа
    private Vector3 moveVector; // направление движения персонажа

    //Ссылки на компоненты
    private CharacterController ch_controller;
    private Animator ch_animator;

    private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        CharacterMove();
        GamingGravity();
    }

    // метод перемещения персонажа
    private void CharacterMove()
    {
        if (ch_controller.isGrounded)
        {
            //перемещение по поверхности
            moveVector = Vector3.zero;
            moveVector.x = Input.GetAxis("Horizontal") * speedMove;
            moveVector.z = Input.GetAxis("Vertical") * speedMove;
           // Debug.Log(moveVector.x);
           // Debug.Log(moveVector.z);
            /*
            //анимация персонажа
            if (moveVector.x != 0 || moveVector.z != 0)
            {
                ch_animator.SetBool("Move", true);
            }
            else {
                ch_animator.SetBool("Move", false); 
            }
           */
            //поворот персонажа
            if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
            {
                Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
                transform.rotation = Quaternion.LookRotation(direct);
            }

        }

        moveVector.y = gravityForce; // расчет гравитции, выполнять после поворота!!!
        ch_controller.Move(moveVector * Time.deltaTime); //метод передвижения по направлениям
    }
    
    //метод гравитации
    private void GamingGravity()
    {
        if (!ch_controller.isGrounded) gravityForce -= 40f * Time.deltaTime;
        else gravityForce = -1f;
        if (Input.GetKeyDown(KeyCode.Space) && ch_controller.isGrounded) gravityForce = jumpPower;
    }






    private void Jump() 
    {

    }

}
