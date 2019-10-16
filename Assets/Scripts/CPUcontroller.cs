using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUcontroller : MonoBehaviour
{
    public float movementSpeed;
    public Transform laptop;
    public SpriteRenderer spriteRend;
    public Color laptopColor;
    public Color lowHealth;
    public Color extremeLow;
    public float healthDecrease = 5f;
    public Rigidbody2D rigidBody;

    [Range(0, 100)]
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        string name = "Laura";
        Debug.Log(name);

        spriteRend.color = laptopColor;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            health = health - 1 + healthDecrease * Time.deltaTime; //Decrease Health
        }
        else if (Input.GetKey(KeyCode.E))
        {
            health = health + 1 + healthDecrease * Time.deltaTime;
        }

        if (health > 50) {
            spriteRend.color = laptopColor;
                }

        else if (health < 50)
        {
            spriteRend.color = lowHealth;
        }
        else if (health < 25)
        {
            spriteRend.color = extremeLow;
        }
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // laptop.position = new Vector3(laptop.position.x + (movementSpeed * x),laptop.position.y + (movementSpeed*y),0);
        rigidBody.velocity = new Vector2(x, y)*movementSpeed;
    }
}
