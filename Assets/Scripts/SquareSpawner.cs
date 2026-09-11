using UnityEngine;

public class SquareSpawner : MonoBehaviour
{

    Vector2 blooey = new Vector2(20, 20);
    Vector2 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //get mouse position
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Debug.DrawLine(Vector2.zero, mousePos, Color.red, 999);
    }
}
