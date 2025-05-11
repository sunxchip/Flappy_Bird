using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float moveSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        transform.position +=Vector3.left * moveSpeed * Time.deltaTime;
    }
}
