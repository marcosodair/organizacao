using JetBrains.Annotations;
using System;
using UnityEngine;
using UnityEngine.UI;

public class geral : MonoBehaviour
{
    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public GameObject gameOver, PersonagemPrincipal, ferramenta;
    






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        recordeNum = 0;

    }

    public void marcarponto()
    {
        placarJogadorNum += 1;
        if (recordeNum < placarJogadorNum) recordeNum += 1;

        atualizarTextoPlacar();
        GetComponent<AudioSource>().Play(); 
    }


    public void atualizarTextoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados:" + placarJogadorNum;
        recordeTexto.text = "Recorde atual:" + recordeNum;

    }
    public void InciarPartida()
    {
        placarJogadorNum = 0;
        atualizarTextoPlacar();


        //reposicionar ferramenta
        ferramenta.GetComponent<Controladorferramenta>().posicaoferramenta =new Vector3(0, 0, 0);
        //voltar a velocidade para o "padrão"
        ferramenta.GetComponent<Controladorferramenta>().deslocamentoferramenta = ferramenta.GetComponent<Controladorferramenta>().deslocamentoinicial;

        //reposicionar luva
        PersonagemPrincipal.transform.position = new Vector3(875, 250, 0);
     //sumir o game-over
     gameOver.SetActive(false);

    }


}

