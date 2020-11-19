using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenControls : MonoBehaviour
{
    public void BtnClick()
    {
        SceneManager.LoadScene("Instructions");
        //Application.LoadScene
    }
}
