using UnityEngine;


public class Ball_clone : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    private GameObject scores_number;


    private void Start()
    {
        scores_number = GameObject.Find("scores_number");
    }

    public void create_ball()
    {
        float random_x = (float)(new System.Random().NextDouble() * (-1f + 3f) - 1f), 
              random_y = (float)(new System.Random().NextDouble() * (4f - 3f) + 3f);
        
        scores_number.GetComponent<Scores_number>().change_scores
        (
            ball.gameObject.GetComponent<Color_types>().get_cost() * -1
        );

        Instantiate(ball, new Vector2(random_x, random_y), Quaternion.identity);
    }
}
