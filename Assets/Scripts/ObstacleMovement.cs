using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyGun
{
    public class ObstacleMovement : MonoBehaviour
    {
        private GameObject parentObject;

        private void Update()
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Destroyer"))
            {
                parentObject = GameObject.FindWithTag("Obstacle");
                Destroy(parentObject);

            }

            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("Player was hit");
            }
        }
    }
}
