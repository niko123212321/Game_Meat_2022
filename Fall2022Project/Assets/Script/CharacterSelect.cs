using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CharacterSelect : MonoBehaviour
{
    CharacterSelected CS;
    int character = 0; // 0 for Moses, 1 for Noah
    // Start is called before the first frame update
    void Start()
    {
        CS = FindObjectOfType<CharacterSelected>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectButton()
    {
        CS.playerSelected = character;
        SceneManager.LoadScene("Race Track");
    }

    void OnMove(InputValue input)
    {
        if (input.Get<Vector2>().x < 0)
        {
            if (character == 0)
                character = 1;
            else
                character--;
            

        }
        else if (input.Get<Vector2>().x > 0)
        {
            if (character == 1)
                character = 0;
            else
                character++;
        }
    }

}
