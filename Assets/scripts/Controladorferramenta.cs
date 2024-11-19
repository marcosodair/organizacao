using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UIElements;

public class Controladorferramenta : MonoBehaviour
{
    public Vector3 posicaoferramenta;
    public float deslocamentoferramenta;
    public float incrementovelocidade;

    internal float deslocamentoinicial;
    internal int sentidoV;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        deslocamentoinicial = deslocamentoferramenta;
          
    }

    // Update is called once per frame
    void Update()
    {
        posicaoferramenta.x = posicaoferramenta.x += deslocamentoferramenta * Time.deltaTime;

        posicaoferramenta.y = posicaoferramenta.y += deslocamentoferramenta * Time.deltaTime * sentidoV;


        transform.position = posicaoferramenta;

        //arrumar sentindo vertical;

        if (transform.position.y >= 465 && sentidoV == 1) sentidoV = -1;

        if (transform.position.y <= 35 && sentidoV == -1) sentidoV = 1;

        deslocamentoferramenta += incrementovelocidade * Time.deltaTime;
    }



    
       

    
     
    
}
