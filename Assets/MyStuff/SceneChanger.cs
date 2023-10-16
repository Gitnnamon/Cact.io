using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeAir()
    {
        SceneManager.LoadScene("Aire");
    }
    public void ChangeFire()
    {
        SceneManager.LoadScene("Fuego");
    }
    public void ChangeWater()
    {
        SceneManager.LoadScene("Agua");
    }
}
