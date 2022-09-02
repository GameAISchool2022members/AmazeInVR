using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Maze mazePrefab;

	public GameObject mazeAgentPrefab;
	public GameObject vrPlayerPrefab;
	public GameObject goalPrefab;

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
		BeginGame();
	}
	
	private void Update () {
		//if (Input.GetKeyDown(KeyCode.Space)) {
		//	RestartGame();
		//}
	}

	private void BeginGame () {
		mazeInstance = Instantiate(mazePrefab) as Maze;
		StartCoroutine(mazeInstance.Generate());
	}

	public void MazeFinished()
    {
		// Instantiate AI Agent
		if(mazeAgentPrefab != null)
        {
			GameObject go = Instantiate(mazeAgentPrefab, Vector3.zero, Quaternion.identity);
			//MazeAgent mazeAgent = go.GetComponent<MazeAgent>();
		}

		// Instantiate VR player
		if(vrPlayerPrefab != null)
        {
			GameObject goPlayer = Instantiate(vrPlayerPrefab, Vector3.zero, Quaternion.identity);
			//MazeAgent player = go.GetComponent<MazeAgent>();
		}

		if(goalPrefab != null)
        {
			GameObject goal = Instantiate(goalPrefab, Vector3.zero, Quaternion.identity);
			//MazeAgent player = go.GetComponent<MazeAgent>();
		}
	}

	private void RestartGame () {
		StopAllCoroutines();
		Destroy(mazeInstance.gameObject);
		BeginGame();
	}
}