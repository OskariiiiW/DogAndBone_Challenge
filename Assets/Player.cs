using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour, IPointerClickHandler
{
    private Rigidbody2D rb;
    private Vector3 screenPosition;
    private bool isActive;
    private float timer = 0; // used for high score
    public GameObject objectToHide;
    public GameObject loseScreen;
    public GameObject winScreen;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Cursor.lockState = CursorLockMode.Confined;
        AddPhysics2DRaycaster();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isActive = true;
        objectToHide.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        screenPosition = Input.mousePosition;
        screenPosition.z = 10.0f;

        if (isActive)
        {
            rb.transform.position = Camera.main.ScreenToWorldPoint(screenPosition);
            timer = timer + Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            audioSource.Play();
            winScreen.SetActive(true);
            if (timer > PlayerPrefs.GetFloat("HighScore"))
            {
                PlayerPrefs.SetFloat("HighScore", timer);
                PlayerPrefs.Save();
                Debug.Log("New High Score: " + timer);
            }
        }
        else
        {
            loseScreen.SetActive(true);
        }
        isActive = false;

    }
    
    private void AddPhysics2DRaycaster() // used for detecting user clicking
    {
        Physics2DRaycaster physicsRaycaster = FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }
}
