using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackChooseDifficult : MonoBehaviour
{
    public void backChooseDifficult()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
