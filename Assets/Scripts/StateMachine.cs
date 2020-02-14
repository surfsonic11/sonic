using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public State currentState;
    private State previousState;
    
    
    public float executeTimer = 0;
    //Função chamada no Update() da classe Main
    public void ExecuteState()
    {
        Debug.Log("Executando...");
        currentState.Execute();
    }

    //Função de troca de estado
    public void ChangeState(State newstate)
    {
        if(currentState != null)
        {
            //Parar o estado atual
            currentState.Exit();

            //Armazenar o estado que estava executando anteriormente
            previousState = currentState;
        }
        
        //Colocar um novo estado
        currentState = newstate;

        //Executar função para "entrar" no novo estado
        currentState.Enter();
    }
}
