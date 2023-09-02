using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // variavel booleana (recebe apenas um valor que pode ser verdadeiro ou falsa) para identificar o jogador a esquerda
    public bool isPlayerLeft;
    // Variavel que armazena o valor da velocidade das plataformas dos jogadores
    public float speed;
    // variavel que acessa o componente rigidbody 2D das plataformas 
    public Rigidbody2D rb;
    // variavel que armazena o valor referente aos movimentos das plataformas 
    public float movement;
    // obs: variaveis publicas podem ter seus alores alterados diretamente pela unity


    // a função update é chamado a cada atualização de um frame
    void Update()
    {
        // verifica se a viaravel booleana isPlayerleft é verdadeira 
        if (isPlayerLeft)
            // caso seja verdadeira
        {
            // Armazena o valor da entrada Vertical1 na variavel movement
            movement = Input.GetAxisRaw("Vertical1");
        }
            // caso a variavel seja falsa 
        else
        {
            // armazena o valor da entrada vertical1 na variavel movement 
            movement = Input.GetAxisRaw("vertical2");
        }
        // atribui a velocidade do componente rigidbody um novo vetor x,y
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
