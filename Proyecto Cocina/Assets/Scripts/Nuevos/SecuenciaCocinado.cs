using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuenciaCocinado : MonoBehaviour
{
    public Sprite sprite1; 
    public Sprite sprite2; 
    public Sprite sprite3; 
    public Sprite sprite4; 
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        if (spriteRenderer.sprite == null) 
            spriteRenderer.sprite = sprite1; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ChangeTheDamnSprite(); 
        }
    }

    void OnTriggerEnter(Collider other)
    {

    }

    void ChangeTheDamnSprite()
    {
        if (spriteRenderer.sprite == sprite1) 
        {          
            spriteRenderer.sprite = sprite2;
        }else
        {
            if (spriteRenderer.sprite == sprite2)
            {
                spriteRenderer.sprite = sprite3;
            }
            else
            {
                if (spriteRenderer.sprite == sprite3)
                {
                    spriteRenderer.sprite = sprite4;
                }
                else
                {
                    if (spriteRenderer.sprite == sprite4)
                    {
                        spriteRenderer.sprite = sprite5;
                    }
                    else
                    {
                        if (spriteRenderer.sprite == sprite5)
                        {
                            spriteRenderer.sprite = sprite6;
                        }
                        else
                        {
                            if (spriteRenderer.sprite == sprite6)
                            {
                                spriteRenderer.sprite = sprite7;
                            }
                            else
                            {
                                if (spriteRenderer.sprite == sprite7)
                                {
                                    spriteRenderer.sprite = sprite1;
                                }
                            }
                        }
                    }
                }
            }
        }











    }
}
