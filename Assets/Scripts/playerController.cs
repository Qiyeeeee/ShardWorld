using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private Collider2D coll;
    public GameObject myself;

    [Header("�ƶ�����")]
    public float speed = 8f;

    float xVelocity;

    [Header("��Ծ����")]
    public float jumpForce = 6f;

    int jumpCount;//��Ծ����

    [Header("״̬")]
    public bool isOnGround;

    [Header("�������")]
    public LayerMask groundLayer;

    //��������
    bool jumpPress;

    int speedID;
    int groundID;
    int fallID;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
        

        speedID = Animator.StringToHash("speed");
        groundID = Animator.StringToHash("isOnGround");
        fallID = Animator.StringToHash("yVelocity");
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpPress = true;
        }
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            Instantiate(myself, new Vector3(-3.451f, -1.506f, 0), Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        isOnGroundCheck();
        Move();
        Jump();
        AnimChange();
    }

    void isOnGroundCheck()
    {
        ////�жϽ�ɫ��ײ�������ͼ�㷢���Ӵ�
        if (coll.IsTouchingLayers(groundLayer))
        {
            if(rb.velocity.y<1&& rb.velocity.y > -1)
            {
                isOnGround = true;
            }
        }
        else
        {
            isOnGround = false;
        }
    }

    void Move()
    {
        xVelocity = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);

        //���淭ת
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity, 1, 1);
        }
    }

    void Jump()
    {
        //�ڵ�����
        if (isOnGround)
        {
            jumpCount = 1;
        }
        //�ڵ�������Ծ
        if (jumpPress && isOnGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
            jumpPress = false;
        }
        //�ڿ�����Ծ
        else if (jumpPress && jumpCount > 1 && !isOnGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
            jumpPress = false;
        }
        jumpPress = false;
    }

    void AnimChange()
    {
        anim.SetFloat(speedID, Mathf.Abs(rb.velocity.x));
        anim.SetBool(groundID, isOnGround);
        anim.SetFloat(fallID, rb.velocity.y);
    }
}
