using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinControl : MonoBehaviour
{

    public Transform bottombunObj;
    public Transform topbunObj;
    public Transform burgerObj;
    public Transform backrollObj;
    public Transform frontrollobj;
    public Transform hotdogObj;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //instancia los panes hacia la tabla con coordenadas
        if (gameObject.name == "bun bin")
        {
            if (Gameplay.TablaCortarS1 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(-1, -0.5f), bottombunObj.rotation);
                Instantiate(topbunObj, new Vector2(-1, -0.4f), bottombunObj.rotation);
                Gameplay.TablaCortarS1 = "justbun";
                Gameplay.salectedSlot = 1;
            }
            else
            {
                if (Gameplay.TablaCortarS2 == "empty")
                {
                    Instantiate(bottombunObj, new Vector2(0, -0.5f), bottombunObj.rotation);
                    Instantiate(topbunObj, new Vector2(0, -0.4f), bottombunObj.rotation);
                    Gameplay.TablaCortarS2 = "justbun";
                    Gameplay.salectedSlot = 2;
                }
                else
                {
                    if (Gameplay.TablaCortarS3 == "empty")
                    {
                        Instantiate(bottombunObj, new Vector2(1, -0.5f), bottombunObj.rotation);
                        Instantiate(topbunObj, new Vector2(1, -0.4f), bottombunObj.rotation);
                        Gameplay.TablaCortarS3 = "justbun";
                        Gameplay.salectedSlot = 3;
                    }
                }


            }

        }

        if (gameObject.name == "hamburgers")
        {
            if (Gameplay.ParrilaS1 == "empty")
            {
                Instantiate(burgerObj, new Vector2(5.5f, 0), burgerObj.rotation);
                Gameplay.ParrilaS1 = "full";

            }
            else
            {
                if (Gameplay.ParrilaS2 == "empty")
                {
                    Instantiate(burgerObj, new Vector2(6.5f, 0), burgerObj.rotation);
                    Gameplay.ParrilaS2 = "full";

                }
                else
                {
                    if (Gameplay.ParrilaS3 == "empty")
                    {
                        Instantiate(burgerObj, new Vector2(7.5f, 0), burgerObj.rotation);
                        Gameplay.ParrilaS3 = "full";

                    }
                }
            }

        }

        if (gameObject.name == "hotdog bin")
        {
            if (Gameplay.ParrilaS1 == "empty")
            {
                Instantiate(hotdogObj, new Vector2(5.5f, 0), hotdogObj.rotation);
                Gameplay.ParrilaS1 = "full";

            }
            else
            {
                if (Gameplay.ParrilaS2 == "empty")
                {
                    Instantiate(hotdogObj, new Vector2(6.5f, 0), hotdogObj.rotation);
                    Gameplay.ParrilaS2 = "full";

                }
                else
                {
                    if (Gameplay.ParrilaS3 == "empty")
                    {
                        Instantiate(hotdogObj, new Vector2(7.5f, 0), hotdogObj.rotation);
                        Gameplay.ParrilaS3 = "full";

                    }
                }
            }

        }
    }

}
