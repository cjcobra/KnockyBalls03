using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript02 : MonoBehaviour
{
    public Text BulletsText;
    private int countBullets;
    public static int saveBulletCount;

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    public float bulletSpeed;
    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        countBullets = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {

            Debug.Log("playerScript02: Fire1");
            countBullets = countBullets + 1;

            // Save Bullet Count
            PlayerPrefs.SetInt("bulletCount", countBullets);

            //Recall Level
            saveBulletCount = PlayerPrefs.GetInt("bulletCount");

            SetBulletsText();
            Shoot();

        }

    }

    void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {
            targetPosition = hit.point;
            //   this.transform.LookAt(targetPosition);
            //   Debug.Log(hit);

            Instantiate(rocketPrefab, barrelEnd.position, Quaternion.LookRotation(ray.direction));

        }
    }

    void SetBulletsText()
    {

        BulletsText.text = "Bullets Fired: " + countBullets.ToString();   // ScoreText.text = "Score: " + score.ToString();

    }

}
