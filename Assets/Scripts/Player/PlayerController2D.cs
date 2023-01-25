using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyGun
{
    public class PlayerController2D : MonoBehaviour
    {
        public Rigidbody2D rb2d;
        private bool jump = false;
        public float jumpCooldown;
        public float jumpForce;

        private void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
            //rb2d = GetComponentInChildren<Rigidbody2D>();

        }

        private void FixedUpdate()
        {
            if (jump)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(cooldown());
            }
        }

        private IEnumerator cooldown()
        {
            jump = true;
            yield return new WaitForSeconds(jumpCooldown);
            jump = false;
        }
    }
}
