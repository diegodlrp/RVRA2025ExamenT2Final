using UnityEngine;

public class Object_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;
    private Vector3 moveDirection;
    [SerializeField] float delay = 5;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Destroy(this.gameObject, delay);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * 0.2f * Time.deltaTime);
    }

}
