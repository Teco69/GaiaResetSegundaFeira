using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerapersoX : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimentação
    public float leftLimit = 2f; // Limite para a esquerda
    public float rightLimit = 5f; // Limite para a direita
    
    private float initialX;

    void Start()
    {
        initialX = transform.position.x; // Salva a posição inicial da câmera
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Entrada do jogador (A/D ou Setas Esquerda/Direita)
        float newX = transform.position.x + moveInput * moveSpeed * Time.deltaTime;
        
        // Garante que a câmera não ultrapasse os limites personalizados
        newX = Mathf.Clamp(newX, initialX - leftLimit, initialX + rightLimit);
        
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
