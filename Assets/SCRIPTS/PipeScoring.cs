using UnityEngine;

public class PipeScoring : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        GameManager.Instance.UpdateScore();
    }
}
