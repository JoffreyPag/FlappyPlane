using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float velocidade = 5f;

    private Rigidbody2D mrb;
    // Start is called before the first frame update
    void Start()
    {
        mrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Subir();

        LimitandoVelocidade();

    }

    private void LimitandoVelocidade()
    {
        if (mrb.velocity.y < -velocidade) mrb.velocity = Vector2.down * velocidade;
    }

    public void Subir() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mrb.velocity = Vector2.up * velocidade;
        }
    }
}
