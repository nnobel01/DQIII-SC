using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuackControl : MonoBehaviour
{


    //Audio
    [SerializeField] private AudioSource footstep;
    [SerializeField] private AudioSource attack;
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource land;
    [SerializeField] private AudioSource hit;

    /* //Attack Variable
    public float attackCoolDownRate = 1.0f;
    private float attackisCool;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    */

    // Movement Speed
    public float speed = 2f;
    public float maxSpeed = 2f;

    // Jump Mechanics
    public Vector2 jump;
    public float jumpForce = 10f;
    public bool canJump = false;
    public bool inAir = false;

    Rigidbody2D _rb;

    private void Start()
    {
        _rb = transform.GetComponent<Rigidbody2D>();
        jump = new Vector2(0, 1);
        Physics.IgnoreLayerCollision(11, 10, true);
        

    }



    //check if touch platform or bouncing off enemy

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            canJump = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            
            inAir = true;
        }
    } 


    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;
        

        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            _rb.velocity = Vector2.up * jumpForce;
            canJump = false;
            jumpSound.Play();


        }
        if (Input.GetKeyDown(KeyCode.W) && inAir)
        {
            _rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            inAir = false;
            jumpSound.Play();
        }

        /* if (Input.GetKeyDown(KeyCode.Space) && Time.time > attackisCool)
        {
            Punch();
            attackisCool = Time.time + attackCoolDownRate;

        } */





    }
    // Attack Controller


      /*  void Punch()
        {


            //Test
            Debug.Log("Attacking");

            //Detect Enemies

            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            //Deal Damage

            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(1);
            }

            

        } */


//Call Audio 

private void FootStep()
    {
        footstep.Play();
    }

    private void Attack()
    {
        attack.Play();
    }

    private void JumpSound()
    {
        jumpSound.Play();
    }

    private void Land()
    {
        land.Play();
    }

    private void Hit()
    {
        hit.Play();
    }


    
}
