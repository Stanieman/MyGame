using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;
    

    void Start()
    {
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame.
    // "Fixed"Update is used when we are using physics.
    void FixedUpdate()
    {
        // Adds a force of 2000(forwardForce) to the Z axis
        // "* Time.deltaTime" handles frame rate
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        




    }
}
