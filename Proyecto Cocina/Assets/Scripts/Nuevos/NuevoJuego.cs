using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevoJuego : MonoBehaviour
{
    public string name;
    public Animator anim;


    private void OnMouseDown()
    {
        IniciarJuego();
    }

    public void IniciarJuego()
    {
        anim.SetBool("Ganar", true);


        SceneManager.LoadScene(name);

    }



}
