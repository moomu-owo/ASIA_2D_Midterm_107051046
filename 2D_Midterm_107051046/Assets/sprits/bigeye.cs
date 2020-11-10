
using UnityEngine;
using UnityEngine.UI;

public class bigeye : MonoBehaviour
{
    public GameObject final;
    public Text textcount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送們")
        {
            final.SetActive(true);
        }
        if (collision.tag == "南瓜瓜")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = "PUMPKIN /" + count;
        }
    }
}
