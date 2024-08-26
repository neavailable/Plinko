using UnityEngine;


public abstract class Ball : Color_types
{
    [SerializeField] private GameObject scores_number;
 

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D == null) return;

        Color_types collision2D_color = collision2D.gameObject.GetComponent<Color_types>();

        if ( collision2D.gameObject.CompareTag("score_box") )
        {
            if (collision2D_color.get_color() == color) scores_number.GetComponent<Scores_number>().change_scores(3);
            
            Destroy(gameObject);
        }
    }

    protected void Update()
    {
        if (transform.position.y < -10) Destroy(gameObject);
    }
}