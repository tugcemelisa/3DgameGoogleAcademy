using UnityEngine;

public class Test : MonoBehaviour
{
	[ContextMenu("Debug")]
	public void Start()
	{
		Debug.Log("Forward V3: " + Vector3.forward);
		Debug.Log("Up V3: " + Vector3.up);
	}
}
