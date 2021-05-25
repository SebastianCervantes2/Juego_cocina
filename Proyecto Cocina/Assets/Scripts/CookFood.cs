using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookFood : MonoBehaviour
{

    public float cookingTime = 0;

    public int occupiedSlot = 100;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(occupiedSlot + " " + Gameplay.selectedDandwhich);

        if (occupiedSlot == Gameplay.selectedDandwhich)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(objPosition.x, objPosition.y - 0.2f);

        }

        cookingTime += Time.deltaTime;
        if ((cookingTime> 6 && cookingTime < 10) && (transform.position.x > 5))
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
        }

        if ((cookingTime > 10) && (transform.position.x > 5))
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }



    }

    private void OnMouseDown()
    {

        if (transform.position.x == 5.5)
        {
            Gameplay.ParrilaS1 = "empty";
        }
        if (transform.position.x == 6.5)
        {
            Gameplay.ParrilaS2 = "empty";
        }
        if (transform.position.x == 7.5)
        {
            Gameplay.ParrilaS3 = "empty";
        }



        if (Gameplay.TablaCortarS1 == "justbun")
        {

            GetComponent<Transform>().position = new Vector2(-1, -0.5f);
            Gameplay.TablaCortarS1 = "fullbun";
            occupiedSlot = 1;
        }
        else
        {
            if (Gameplay.TablaCortarS2 == "justbun")
            {

                GetComponent<Transform>().position = new Vector2(0, -0.5f);
                Gameplay.TablaCortarS2 = "fullbun";
                occupiedSlot = 2;
            }
            else
            {
                if (Gameplay.TablaCortarS3 == "justbun")
                {

                    GetComponent<Transform>().position = new Vector2(1, -0.5f);
                    Gameplay.TablaCortarS3 = "fullbun";
                    occupiedSlot = 3;
                }
            }
        }
    }



}
