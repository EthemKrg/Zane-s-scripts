using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LocalizationManager : MonoBehaviour
{
    public GameSaveManager loadScriptibleData;

    public static LocalizationManager instance;

    private Dictionary<string, string> localizedText;
    private bool isReady = false;
    private string missingTextString = "Localized text not found";


    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void LoadLocalizedText(string fileName)
    {
        loadScriptibleData.LoadStriptables();
        localizedText = new Dictionary<string, string>();

        if (fileName == "LocalizedText_tr")
        {
            TextAsset txt = (TextAsset)Resources.Load("LocalizedText_tr", typeof(TextAsset));
            string filepath = txt.text;
            LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(filepath);

            for (int i = 0; i < loadedData.items.Length; i++)
            {
                localizedText.Add(loadedData.items[i].key, loadedData.items[i].value);
            }


            Debug.Log("Data loaded, dictionary contains: " + localizedText.Count + " entries");

            isReady = true;
        }

        if (fileName == "LocalizedText_en")
        {
            TextAsset txt = (TextAsset)Resources.Load("LocalizedText_en", typeof(TextAsset));
            string filepath = txt.text;
            LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(filepath);

            for (int i = 0; i < loadedData.items.Length; i++)
            {
                localizedText.Add(loadedData.items[i].key, loadedData.items[i].value);
            }


            Debug.Log("Data loaded, dictionary contains: " + localizedText.Count + " entries");

            isReady = true;
        }









    }

    public string GetLocalizedValue(string key)
    {
        string result = missingTextString;
        if (localizedText.ContainsKey(key))
        {
            result = localizedText[key];
        }

        return result;

    }

    public bool GetIsReady()
    {
        return isReady;
    }

}