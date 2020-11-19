using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamaOvar : MonoBehaviour
{
    public void BtnClick()
    {
        SceneManager.LoadScene("GameOver");
        //Application.LoadScene
    }
}
