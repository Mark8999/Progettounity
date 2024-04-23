using UnityEngine;


public class WInCondition : MonoBehaviour

{
    private UIManager uiManager;
    public GameObject Canvas;
    private void Start()
    {
        uiManager = Canvas.GetComponent<UIManager>(); 
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("ciao");
            uiManager.Win();
        
        }
    }

    
}
