using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyGun
{
    public class BulletAction : MonoBehaviour
    {
        public Rigidbody2D rb2d;

        private void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            rb2d.MovePosition((Vector2)transform.position + (Vector2.right * 10 * Time.deltaTime));

            // Good for shooter games recoil
            //rb2d.velocity = new Vector2(10, rb2d.velocity.y);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            
        }
    }
}
