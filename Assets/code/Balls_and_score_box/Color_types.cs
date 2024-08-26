using UnityEngine;


public abstract class Color_types : MonoBehaviour
{
    public enum color_types {red, green, purple}

    [SerializeField] protected color_types color;

    public color_types get_color()
    {
        return color;
    }
}
