using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyGun
{
    public class PlayerShooter : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public GameObject bulletPosition;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                ShootBullet();
            }       
        }

        void ShootBullet()
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletPosition.transform.position, Quaternion.identity);
            Rigidbody2D rb2d = bullet.GetComponent<Rigidbody2D>();
            rb2d.velocity = transform.right * 10f;
            //rb2d.AddForce(bulletPosition.transform.right * 10f, ForceMode2D.Impulse);

            Destroy(bullet, .5f);
            //rb2d.MovePosition(bulletPosition.position + (bulletPosition.right * 10 * Time.deltaTime));
        }
    }
}
