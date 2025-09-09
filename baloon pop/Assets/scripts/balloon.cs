using UnityEngine;

public class balloon : MonoBehaviour
{
    public int clicktoPop = 3;
    public float scaleToincrease = 0.10f;
    public int scoreTogive;
    private ScoreManager scoreManager;
    //public GameObject popEffect
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //scoreManager + GameObject.Find("ScoreManager").GetComponent<ScoreManager();
    }

    // Update is called once per frame
    void onMouseDown()
    {
        clickToPop -=1;
        transform.localScale += Vector3.one * scaleToincrease;
        //if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            //Insantiate(popEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }




    }
}
