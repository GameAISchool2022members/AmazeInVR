using UnityEngine;
using System.Collections;
using ExciteOMeter;

public class GameManager : MonoBehaviour {

	public Maze mazePrefab;
	public GameObject mazeGO;

	public GameObject cameraTopGO;
	public GameObject vrPlayerGO;
	public GameObject mazeAgentGO;
	public GameObject goalGO;

	private Maze mazeInstance;

	public static GameManager instance;

    private void Awake()
    {
		if (instance == null)
			instance = this;
		else
			Destroy(this.gameObject);
    }

    private void Start () {
		//BeginGame();
	}
	
	private void Update () {
		//if (Input.GetKeyDown(KeyCode.Space)) {
		//	RestartGame();
		//}
	}

	public void BeginGame () {
		cameraTopGO.SetActive(true);
		vrPlayerGO.SetActive(false);
		mazeAgentGO.SetActive(false);
		goalGO.SetActive(false);


		mazeGO = Instantiate(mazePrefab.gameObject);
		mazeInstance = mazeGO.GetComponent<Maze>();

		StartCoroutine(mazeInstance.Generate());
	}

	public void MazeFinished()
    {
		cameraTopGO.SetActive(false);
		vrPlayerGO.SetActive(true);
		mazeAgentGO.SetActive(true);
		goalGO.SetActive(true);


		// Increase size of maze
		mazeGO.transform.localScale = new Vector3(2f, 1f, 2f);

		//EnemyDetector.instance.SetEnemies(mazeAgentGO.transform);
	}

	public void EndGame()
    {
		ExciteOMeterManager.instance.StartOrStopSessionLog();
	}

	private void RestartGame () {
		StopAllCoroutines();
		Destroy(mazeInstance.gameObject);
		BeginGame();
	}
}