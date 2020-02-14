using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected string stateName;

    public abstract void Enter();

    public abstract void Exit();

    public virtual void Execute()
    {
        Debug.Log(stateName);
    }
}

public class PlayingState : State
{
    public PlayingState(string name)
    {
        stateName = name;
    }

    public override void Enter()
    {
        Debug.Log("Entrando no estado: " + stateName);
        //Main.singleton.CoState()
    }

    public override void Execute()
    {
        Debug.Log(stateName);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.paused);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.spawn);
        }
    }

    public override void Exit()
    {
        Debug.Log("Saindo do Estado: " + stateName);
    }
}

public class PausedState : State
{

    public PausedState(string name)
    {
        stateName = name;
    }

    public override void Enter()
    {
        Debug.Log("Entrando no estado: " + stateName);
    }

    public override void Execute()
    {
        Debug.Log(stateName);
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.playing);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.spawn);
        }
    }

    public override void Exit()
    {
        Debug.Log("Saindo do Estado: " + stateName);
    }
}

public class SpawnState : State
{
    
    public SpawnState (string name)
    {
        stateName = name;
        
    }

    public override void Enter()
    {
        Debug.Log("Entrando no estado: " + stateName);
    }

    public override void Execute()
    {
        Debug.Log(stateName);

        if (Input.GetKey(KeyCode.B))
        {
            Main.singleton.SpawnPrefab();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.playing);
        }


    }

    public override void Exit()
    {
        Debug.Log("Saindo do Estado: " + stateName);
    }
}