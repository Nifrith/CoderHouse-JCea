using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSigner : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;
    // Start is called before the first frame update
    void Start()
    {
       m_Object.text = SceneManager.GetActiveScene().name;

    }

}
