using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour 
{
    public string nextLevel = "GeoLevel_2";

    private void OnTrigerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Death":
                {
             string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
        }
    }
}
