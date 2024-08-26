using TMPro;
using UnityEngine;


public class Scores_number : MonoBehaviour
{
    private int scores;
    private TMP_Text text_component;


    private void Start()
    {
        scores = 200;

        text_component = gameObject.GetComponent<TMP_Text>();

        text_component.text = "scores: " + scores;
    }

    public void change_scores(int scores_)
    {
        scores += scores_;

        text_component.text = "scores: " + scores;
    }

    private bool check_losing()
    {
        return scores <= 0 ? true : false;
    }

    private void lose()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            if (obj != gameObject && obj.GetComponent<Camera>() == null && obj.scene.name != null) Destroy(obj); 
        }
    }

    private void Update()
    {
        if ( check_losing() ) lose();
    }
}
