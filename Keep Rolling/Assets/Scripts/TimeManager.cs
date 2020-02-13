/*using UnityEngine;

public class TimeManager : MonoBehaviour
{

	public float slowdownFactor = 0.05f;
	public float slowdownLength = 1f;

	void FixedUpdate()
	{
		Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
	
	}

	public void DoSlowmotion()
	{
		Time.timeScale = slowdownFactor;
		Time.fixedDeltaTime = Time.timeScale * .02f;
	}

}*/