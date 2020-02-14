using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main singleton;

    public GameObject[] prefab;

    

    public StateMachine stateMachine = new StateMachine();

    public PlayingState playing = new PlayingState("Playing");
    public PausedState paused = new PausedState("Paused");
    public SpawnState spawn = new SpawnState("Spawning");
    public float changeNumber;
    

    void Awake()
    {
        if(singleton != this && singleton != null)
        {
            GameObject.Destroy(this);
        }
        else
        {
            singleton = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
        stateMachine.ChangeState(playing);   
        
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.ExecuteState();
    }

    //public IEnumerator CoState()
    //{
        
    //    while (waitForExecute == true)
    //    {
            
    //        stateMachine.ExecuteState();
    //        yield return null;
    //    }
        
    //}

    public void SpawnPrefab()
    {
        changeNumber = Random.Range(1, 4);
        
        //switch (randomColor)
        //{
        //    case 1:
        //        prefab[1].GetComponent<Renderer>().sharedMaterial.color = Color.black;
        //        break;
        //    case 2:
        //        prefab[1].GetComponent<Renderer>().sharedMaterial.color = Color.green;
        //        break;
        //    case 3:
        //        prefab[1].GetComponent<Renderer>().sharedMaterial.color = Color.red;
        //        break;
        //    case 4:
        //        prefab[1].GetComponent<Renderer>().sharedMaterial.color = Color.yellow;
        //        break;
        //    case 5:
        //        prefab[1].GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        //        break;
        //    case 6:
        //        prefab[1].GetComponent<Renderer>().sharedMaterial.color = Color.magenta;
        //        break;
        //}
        switch (changeNumber)
        {
            case 1:
                
                Instantiate(prefab[1], Vector3.zero, Quaternion.identity);
                break;
            case 2:
                Instantiate(prefab[2], Vector3.zero, Quaternion.identity);
                break;
            case 3:
                Instantiate(prefab[3], Vector3.zero, Quaternion.identity);
                break;
            case 4:
                Instantiate(prefab[4], Vector3.zero, Quaternion.identity);
                break;
        }
            

        
    }
}
