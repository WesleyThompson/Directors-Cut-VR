﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDying : MonoBehaviour {

    private Animator animator;
    private NavMeshAgent navMeshAgent;
    private CapsuleCollider capsule;
    private AudioSource audio;
    public AudioClip audioClip;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        capsule = GetComponent<CapsuleCollider>();
        audio = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.F))
        {
            EnemyDies();
        }
	}

    public void EnemyDies()
    {
        animator.SetTrigger("Die");
        navMeshAgent.isStopped = true;
        capsule.enabled = false;
        audio.clip = audioClip;
        audio.loop = false;
        audio.Play();
        
    }
}
