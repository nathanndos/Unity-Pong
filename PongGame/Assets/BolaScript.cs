using UnityEngine;

public class BolaScript : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        float speedX = Random.Range(0, 2) == 0 ? 1 : -1;
        float speedY = Random.Range(0, 2) == 0 ? 1 : -1;

        GetComponent<Rigidbody>().velocity = new Vector3(speedX * speed, speedY * speed, 0f);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GetComponent<MeshRenderer>().material.color = collision.gameObject.GetComponent<MeshRenderer>().material.color;
            speed += 0.5f;
        }
    }
}
