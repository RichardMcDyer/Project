using UnityEngine.SceneManagement;
using UnityEngine; 
using UnityEngine.UI;

public class menu : MonoBehaviour {

	public Button StartBtn;
	public Button ExitBtn;
	public Button BonusBtn;
	public Button LeadBtn;
	// Use this for initialization
	void Start () {
		StartBtn.onClick.AddListener (() => {
			SceneManager.LoadScene ("Scene1");
		});
		ExitBtn.onClick.AddListener (() => {
			Application.Quit();
		});
		/*LeadBtn.onClick.AddListener (() => {
			SceneManager.LoadScene("LeaderBoard");
		});*/
		BonusBtn.onClick.AddListener (() => {
			SceneManager.LoadScene ("race_track_lake");
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
