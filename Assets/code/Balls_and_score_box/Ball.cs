using UnityEngine;


public class Ball : Color_types
{
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D == null) return;

        Color_types collision2D_color = collision2D.gameObject.GetComponent<Color_types>();

        if ( collision2D.gameObject.CompareTag("score_box") )
        {
            if (collision2D_color.get_color() == color) Destroy(gameObject);
        }
    }

    protected void Update()
    {
        if (transform.position.y < -10) Destroy(gameObject);
    }
}