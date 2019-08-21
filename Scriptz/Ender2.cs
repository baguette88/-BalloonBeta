
using UnityEngine;

public class Ender2 : MonoBehaviour
{

   //public Player movement;


    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Enemy")
        {
           // movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
         //   GetComponent<RestartButton>;
         //TRY TO ADD RESTART BUTTON
        }
    }
}
