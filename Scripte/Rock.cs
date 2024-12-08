using UnityEngine;

public class Rock : MonoBehaviour
{
    public PlayerMove playerMove;
    public CollisionCheck collisionCheck;
    float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = playerMove.speed;
    }

    // Update is called once per frame
    void Update()
    {
        RockMove();
    }

    private void RockMove()
    {
        if (collisionCheck.hitRight && Input.GetKeyDown(KeyCode.D))
        {
            this.transform.position += transform.right;
        }
        if (collisionCheck.hitLeft && Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position -= transform.right;
        }
        if (collisionCheck.hitUp && Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += transform.up;
        }
        if (collisionCheck.hitDown && Input.GetKeyDown(KeyCode.S))
        {
            this.transform.position -= transform.up;
        }
    }
}
