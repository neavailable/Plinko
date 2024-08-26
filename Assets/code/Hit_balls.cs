using TMPro;
using UnityEngine;


public class Hit_balls : MonoBehaviour
{
    private int hit_balls;

    private TMP_Text text_component;


    private void Start()
    {
        text_component = gameObject.GetComponent<TMP_Text>();

        hit_balls = 0;

        text_component.text = "hit balls: " + hit_balls;
    }

    private void set_hit_balls(int hit_balls_)
    {
        hit_balls = hit_balls_;

        text_component.text = "hit balls: " + hit_balls;
    }

    public void add_hit_ball()
    {
        set_hit_balls(hit_balls + 1);
    }

    private void destroy_balls()
    {
        GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");

        foreach (GameObject ball in balls) Destroy(ball);
    }

    public void reset_hit_balls()
    {
        set_hit_balls(0);

        destroy_balls();
    }
}
