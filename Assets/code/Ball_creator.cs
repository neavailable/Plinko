using UnityEngine;


public class Ball_creator : MonoBehaviour
{
    [SerializeField] private GameObject ball;


    public void create_ball()
    {
        float random_x = (float)(new System.Random().NextDouble() * (-1f + 3f) - 1f), 
              random_y = (float)(new System.Random().NextDouble() * (3f - 2f) + 2f);

        Instantiate(ball, new Vector2(random_x, random_y), Quaternion.identity);
    }
}
