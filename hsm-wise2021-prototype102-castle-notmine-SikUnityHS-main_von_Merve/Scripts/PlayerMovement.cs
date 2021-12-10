using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 3;

     bool alive = true;
    public Vector3 jump;
     public float jumpForce = 2f;
     
    public bool isGrounded;
    [SerializeField] Rigidbody rb;

    private void FixedUpdate ()
    {
        if (!alive) return;
    }

    public void Start()
    {
         rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2f, 0.0f);
    }

    void OnCollisionStay()
         {
             isGrounded = true;
         }

    public void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
              rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                 isGrounded = false;
        }
    }

    public void Die ()
    {
        alive = false;
        Invoke("Restart", 1);
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
