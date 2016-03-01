using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{

    float moveSpeedCharacter = 12.0f;
    

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        bool downMove = Input.GetKey(KeyCode.S);
        bool upMove = Input.GetKey(KeyCode.W);
        bool leftMove = Input.GetKey(KeyCode.A);
        bool rightMove = Input.GetKey(KeyCode.D);



            if (downMove)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -moveSpeedCharacter);
               
            }
            else if (upMove)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, moveSpeedCharacter);
               
            }
            else
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);



            if (leftMove)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeedCharacter, GetComponent<Rigidbody2D>().velocity.y);
             
            }
            else if (rightMove)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeedCharacter, GetComponent<Rigidbody2D>().velocity.y);
                
            }
            else
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);

        }

    
}
