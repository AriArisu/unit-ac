using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.9f;

    [SerializeField]
    private float varairposicaoY;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-varairposicaoY,varairposicaoY));
}
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left*velocidade* Time.deltaTime);

    }
}
