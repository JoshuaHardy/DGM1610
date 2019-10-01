/* using UnityEngine;

public class LectureFunctions : MonoBehaviour
{
    public string playerName;
    private int myNumber;
    public float speed = 5;
    public GameObject player;
    public Color playerColor = Color.red;


  
    // Start is called before the first frame update
    void Start()
    {
        configGameObject();
        //   print(message: WelcomePlayer());
        //  myNumber = AddNumbers();
    }

    private string WelcomePlayer()
    {
        //Add player to database;
        //Give Player Weapons
        return playerName + "Welcome to the Game!";
    }
    private int AddNumbers(int a, int b)
    {
        print(a + b);
        return a + b;
    }

    private GameObject configGameObject()
    {
        var newPlayer = Instantiate(player);
        newPlayer.layer = 0;
        newPlayer.active = true;
        newPlayer.tag = "Player";
        newPlayer.transform.position = Vector3.zero;
        newPlayer.name = playerName;
        newPlayer.GetComponent<Renderer>().material.color = playerColor;
        
        return newPlayer;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(2f);
    }
    
    private float IncreaseSpeed(float multiplier)
    {
        + 2f; //Placeholder;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
