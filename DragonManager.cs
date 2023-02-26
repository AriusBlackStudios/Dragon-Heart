using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DragonManager : MonoBehaviour
{
    public Transform targetPos;

    public NavMeshAgent agent;


    //HABITAT? 
    public Need Health; // order, organization, routine

    public Need Emotion; // inside, personal order and peace, processing feelings and regulation

    public Need Actualization; // achieving your goals, growing your skills, ect

    public Need Relationships; // being a better friend, family member, person

    public Need Tranquillity; //order and organization


    private void Awake() {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        agent.SetDestination(targetPos.position);
    }
}
