using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_efectos : MonoBehaviour
{
    private float velocidad = 5;
    private float velocidadRotacion = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        this.Mover(hor, ver);
    }

    private void Mover(float hor, float ver)
    {
        float velocidadAjustada = this.velocidad * Time.deltaTime;
        this.transform.Translate(new Vector3(0, 0, ver) * velocidadAjustada);
        this.transform.Rotate(Vector3.up * hor * this.velocidadRotacion);
    }
}
