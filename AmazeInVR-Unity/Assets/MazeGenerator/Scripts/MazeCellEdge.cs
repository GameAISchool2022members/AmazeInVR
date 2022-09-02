using UnityEngine;

public abstract class MazeCellEdge : MonoBehaviour {

	public MazeCell cell, otherCell;

	public MazeDirection direction;

	public bool isPassage = false;

	public void Initialize (MazeCell cell, MazeCell otherCell, MazeDirection direction, bool isPassage = false) {
		this.cell = cell;
		this.otherCell = otherCell;
		this.direction = direction;
		this.isPassage = isPassage;
		cell.SetEdge(direction, this);
		transform.parent = cell.transform;
		transform.localPosition = Vector3.zero;
		transform.localRotation = direction.ToRotation();
	}
}