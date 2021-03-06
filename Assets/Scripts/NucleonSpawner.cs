﻿using UnityEngine;

public class NucleonSpawner : MonoBehaviour {

	public float timeBetweenSpawns;
	public float spawnDistance;
	public Nucleon[] nucleonPrefabs;

	private float timeSinceLastSpawn;

	private void FixedUpdate () {
		timeSinceLastSpawn += Time.fixedDeltaTime;
		if (timeSinceLastSpawn > timeBetweenSpawns) {
			timeSinceLastSpawn -= timeBetweenSpawns;
			SpawnNucleon ();
		}
	}

	private void SpawnNucleon () {
		Nucleon prefab = nucleonPrefabs [Random.Range (0, nucleonPrefabs.Length)];
		Nucleon spawn = Instantiate<Nucleon> (prefab);
		spawn.transform.localPosition = Random.onUnitSphere * spawnDistance;
		spawn.transform.SetParent (this.transform);
	}
}
