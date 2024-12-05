using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarCrash : MonoBehaviour
{
    public GameObject shield;
    [SerializeField] private AudioSource drive;
    private InvincibleFrame inFrame;
    private Animator animator;
    private CarDriving cd;
    [SerializeField] private AudioSource crash;

    // Start is called before the first frame update
    void Start()
    {
        inFrame = GetComponent<InvincibleFrame>();
        animator = GetComponent<Animator>();
        cd = GetComponent<CarDriving>();
        crash.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            animator.SetTrigger("Explode");
            cd.isControllable = false;
            Destroy(gameObject, 5f/6f);
            GameManager.GetInstance().Score();
            GameManager.GetInstance().GameOver();
            drive.enabled = false;
            crash.enabled = true;
        }

        if(collision.gameObject.tag == "Shield")
        {
            Destroy(collision.gameObject);
            inFrame.activate();
            shield.SetActive(true);
        }

    }


}
