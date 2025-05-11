using UnityEngine;

public class Groundmover : MonoBehaviour
{
    public float speed = 1f;
    public float width = 6f;

    public SpriteRenderer sr;

    public Vector2 startSize;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startSize = new Vector2(sr.size.x,sr.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        float y = sr.size.y;
        //이전 프레임이 완료 될 때 까지 걸리는 시간
        sr.size = new Vector2(sr.size.x+speed*Time.deltaTime,y);

        if ( sr.size.x > width)
        {
            sr.size = startSize;
        }
    }
}
