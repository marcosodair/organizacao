using Unity.VisualScripting;
using UnityEngine;

public class controladorjogador : MonoBehaviour
{
    public float velocidadedaMaozinha;
    public geral juizdojogo;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // up = subir a luva

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 465)
        {
            Vector3 novapos = new Vector3(0, velocidadedaMaozinha * Time.deltaTime, 0);
            transform.position += novapos;
        }
        // down= descer a luva
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= 35)
        {
            Vector3 novapos = new Vector3(0, velocidadedaMaozinha * Time.deltaTime, 0);
            transform.position -= novapos;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.name.StartsWith("ferramenta"))
      {
            float posicaoY = Random.value * 465;

            collision.GetComponent<Controladorferramenta>().posicaoferramenta.y = posicaoY;
            collision.GetComponent<Controladorferramenta>().posicaoferramenta.x = 0;

            juizdojogo.marcarponto();
                
      
      }         
        
    }
    


}
