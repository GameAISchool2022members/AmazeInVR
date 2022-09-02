using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class V2Comparer : IComparer<Vector2>
 {
     public int Compare(Vector2 left, Vector2 right)
     {
         var dif = left - right;
         if (dif.x == 0 && dif.y == 0)
             return 0;
         else if (dif.x == 0)
             return (int)Mathf.Sign(dif.y);
         return (int)Mathf.Sign(dif.x);
     }
 }

public class MazeAgent : MonoBehaviour
{

    public Maze mazeGenerator;

    int row = 10;
    int col = 10;

    public Vector2 start_cell;
	public Vector2 goal_cell;

    List<MazeDirection> obstacles = new List<MazeDirection>();
    List<string> moves = new List<string>(); 
	float fraction_of_way_there;
	float timeToGo;
	bool flag=true;
	Vector3 initial_pos;
	Vector3 start_pos;
	Vector3 end_pos;

    // int move_cost(Vector2 b){
    //     foreach(MazeDirection barrier in obstacles)
	// 	{
	// 		if(barrier==b)
	// 		{	
	// 			return 1000;
	// 		}
	// 	}
	// 	return 1;
    // }

    	List<Vector2> get_neighbours(Vector2 node)
	{
		Vector2 up = new Vector2((int)node.x,(int)node.y+1);
		Vector2 down = new Vector2((int)node.x,(int)node.y-1);
		Vector2 left = new Vector2((int)node.x-1,(int)node.y);
		Vector2 right = new Vector2((int)node.x+1,(int)node.y);
		
		List<Vector2> list = new List<Vector2>();
		list.Add(up);
		list.Add(down);
		list.Add(left);
		list.Add(right);
		
		foreach(Vector2 n in list)
		{
			if(n.x<0 || n.x>=col || n.y<0 || n.y>=row)
				list.Remove(n);
            
            MazeCell currentCell = mazeGenerator.GetCell(new IntVector2((int)transform.position.x, (int)transform.position.z));
            // if()

			//revisar objetos vecinos y ver si hay paredes que hagan obstáculos
			
		}
		return list;
		
	}

    void Start(){
        GameObject maze = GameObject.Find("Maze_Creator");


    }
}
