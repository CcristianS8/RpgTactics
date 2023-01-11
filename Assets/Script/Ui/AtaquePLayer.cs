using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquePLayer : MonoBehaviour
{


    
    public PlayerMove movePlayer;
    public PlayerMove movimientoBruja;
    public GameObject salir;
    public GameObject move;
    public GameObject moveBruja;
    public GameObject ataque;
    public GameObject end;
    public GameObject ataqueCorto;
    public GameObject ataqueLargo;
    public GameObject atque;
    public GameObject finalEspada;
    public GameObject finalBruja;
    public GameObject iniciaBruja;
    public GameObject iniciaEspada;
    public GameObject ataqueCortoBruja;
    public GameObject ataqueLargoBruja;
    public GameObject ataqueBruja;
    public GameObject salirBruja;
    public GameObject endBruja;





    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hechizos()
    {

        salir.SetActive(true);
        move.SetActive(false);
        end.SetActive(false);

    }

    public void Salir()
    {
        salir.SetActive(false);
        move.SetActive(true);
        end.SetActive(true);
        ataque.SetActive(false);
        salir.SetActive(false);
        ataqueCorto.SetActive(false);
        ataqueLargo.SetActive(false);

    }

    public void Espada()
    {
        ataqueCorto.SetActive(true);
        atque.SetActive(false);

    }

    public void Agua()
    {
        ataqueLargo.SetActive(true);
        ataque.SetActive(false);
    }

    public void Move()
    {
        movePlayer.turn = true;
        StartCoroutine(TiempoMovimiento());
    }    
   

    IEnumerator TiempoMovimiento()
    {
        yield return new WaitForSeconds(5);
        movePlayer.turn = false;
        move.SetActive(false);
    }

    public void MovimietoBruja()
    {
        movimientoBruja.turn = true;
        StartCoroutine(TiempoMovimientoBrujo());
    }

    public void FinalTurnoEspada()
    {
        finalEspada.SetActive(false);
        iniciaBruja.SetActive(true);
        ataqueBruja.SetActive(true);

    }

    IEnumerator TiempoMovimientoBrujo()
    {
        yield return new WaitForSeconds(3.5f);
        movimientoBruja.turn = false;
        moveBruja.SetActive(false);
    }

    public void Veneno()
    {
        ataqueCortoBruja.SetActive(true);
        ataqueBruja.SetActive(false);
        salirBruja.SetActive(true);
       

    }

    public void Viento()
    {
        ataqueLargoBruja.SetActive(true);
        ataqueBruja.SetActive(false);
        salirBruja.SetActive(true);

    }
    public void SalirBruja()
    {
        salirBruja.SetActive(false);
        moveBruja.SetActive(true);
        endBruja.SetActive(true);
        ataqueBruja.SetActive(false);
        ataqueCortoBruja.SetActive(false);
        ataqueLargoBruja.SetActive(false);
    }

    public void HechizosBruja()
    {

        
        moveBruja.SetActive(false);
        endBruja.SetActive(false);

        

    }

    public void FinalTurnoBruja()
    {
        finalBruja.SetActive(false);
        iniciaEspada.SetActive(true);
        ataque.SetActive(true);

    }
}



