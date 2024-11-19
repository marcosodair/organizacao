using UnityEngine;

public class controladorlimite : MonoBehaviour
{
    public GameObject objetoGAMEOVER;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("ferramenta"))
            objetoGAMEOVER.SetActive(true);

    }
}
