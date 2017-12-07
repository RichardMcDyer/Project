using UnityEngine.SceneManagement;
using UnityEngine; 
using UnityEngine.UI;

public class menu : MonoBehaviour {

	public Button StartBtn;
	public Button ExitBtn;
	public Button BonusBtn;
	// Use this for initialization
	void Start () {
		StartBtn.onClick.AddListener (() => {
			SceneManager.LoadScene ("Scene1");
		});
		ExitBtn.onClick.AddListener (() => {
			Application.Quit();
		});
		BonusBtn.onClick.AddListener (() => {
			SceneManager.LoadScene ("race_track_lake");
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
