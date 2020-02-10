using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBehaviour : MonoBehaviour
{
    public InputField name;
    public Slider sound;
    public Toggle subs;
    public void SaveOptions()
    {
        PlayerPrefs.SetString("Name", name.text);
        PlayerPrefs.SetFloat("Sound", sound.value);
        if (subs.isOn)
        {
            PlayerPrefs.SetInt("Subs", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Subs", 0);
        }
        Debug.Log(PlayerPrefs.GetString("name"));
        Debug.Log(PlayerPrefs.GetFloat("sound"));
        Debug.Log(PlayerPrefs.GetInt("subs"));

    }

    public void Awake()
    {
        name.SetTextWithoutNotify(PlayerPrefs.GetString("Name"));
        if (PlayerPrefs.GetInt("Subtitulos") == 1)
        {
            subs.isOn = true;
        }

        else
        {
            subs.isOn = false;
        }

    }
}
