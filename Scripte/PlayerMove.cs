using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.position += transform.right;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position -= transform.right;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += transform.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.position -= transform.up;

        }
    }
}
