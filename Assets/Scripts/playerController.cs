using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private Collider2D coll;
    public GameObject myself;

    [Header("移动参数")]
    public float speed = 8f;

    float xVelocity;

    [Header("跳跃参数")]
    public float jumpForce = 6f;

    int jumpCount;//跳跃次数

    [Header("状态")]
    public bool isOnGround;

    [Header("环境检测")]
    public LayerMask groundLayer;

    //按键设置
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
        ////判断角色碰撞器与地面图层发生接触
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

        //镜面翻转
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity, 1, 1);
        }
    }

    void Jump()
    {
        //在地面上
        if (isOnGround)
        {
            jumpCount = 1;
        }
        //在地面上跳跃
        if (jumpPress && isOnGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
            jumpPress = false;
        }
        //在空中跳跃
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
