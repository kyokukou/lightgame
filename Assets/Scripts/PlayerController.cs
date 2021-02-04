using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    
    private Rigidbody2D myRB;
    public int hp=3;
    public GameObject text;
    public Text hptext;
    [SerializeField]
    private float speed=1500;
    
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //speed allows it to move at a speed faster than 1 
        //time accounts for computers of different speeds
        //Raw axis makes the player move fast at the start rather than having to ramp up speed
        myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
        hptext.text = "hp " + hp.ToString();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {

            hp -= 1;
          //  hptext.text = "hp "+ hp.ToString();
            if (hp <= 0)
            {
                hp = 0;
                text.SetActive(true);
               // Destroy(gameObject);
            }

        }

    }

}
