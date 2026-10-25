using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
	private void Start()
	{
		SceneManager.LoadScene(Game.MainMenuLevelName);
	}
}
