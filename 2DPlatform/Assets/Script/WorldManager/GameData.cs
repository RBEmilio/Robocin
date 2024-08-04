using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
public class GameData : MonoBehaviour
{
    public string data1;
    public string data2;
    public string data3;

    public MyDataGame myDataGame = new MyDataGame();

    private void Awake()
    {
        data1 = Application.dataPath + "/saveFile1.json";
        data2 = Application.dataPath + "/saveFile2.json";
        data3 = Application.dataPath + "/saveFile3.json";

        CreateifNotExist(data1);
        CreateifNotExist(data2);
        CreateifNotExist(data3);

        PrefsCreator();
    }

    #region createFiles
    private void CreateifNotExist(string path)
    {
        if (!File.Exists(path)){
            File.WriteAllText(path, "{}");
            Debug.Log("Archivo creado: " + path);
        }
        else
        {
            Debug.Log("Ya existe el archivo: " + path);
        }
    }
    #endregion

    #region LoadData
    public void LoadData(int num)
    {
          switch(num)
        {
            case 1:
                if (File.Exists(data1))
                {
                    string content = File.ReadAllText(data1);
                    myDataGame = JsonUtility.FromJson<MyDataGame>(content);

                    PlayerPrefs.SetString("nivel1", myDataGame.lvl1);
                    PlayerPrefs.SetString("nivel2", myDataGame.lvl2);
                    PlayerPrefs.SetString("nivel3", myDataGame.lvl3);
                    PlayerPrefs.SetString("nivel4", myDataGame.lvl4);

                    PlayerPrefs.SetInt("SaveData", 1);

                    PlayerPrefs.SetInt("levelsUnlock", myDataGame.levelsUnlock);
                    Debug.Log("carga archivo 1");
                    SceneManager.LoadScene("StartMenu");
                }
                else
                {
                    Debug.Log("Archivo inexistente");
                }
                break;

            case 2:
                if (File.Exists(data2))
                {
                    string content = File.ReadAllText(data2);
                    myDataGame = JsonUtility.FromJson<MyDataGame>(content);

                    PlayerPrefs.SetString("nivel1", myDataGame.lvl1);
                    PlayerPrefs.SetString("nivel2", myDataGame.lvl2);
                    PlayerPrefs.SetString("nivel3", myDataGame.lvl3);
                    PlayerPrefs.SetString("nivel4", myDataGame.lvl4);

                    PlayerPrefs.SetInt("SaveData", 2);

                    PlayerPrefs.SetInt("levelsUnlock", myDataGame.levelsUnlock);
                    Debug.Log("carga archivo 2");
                    SceneManager.LoadScene("StartMenu");
                }
                else
                {
                    Debug.Log("Archivo inexistente");
                }
                break;

            case 3:
                if (File.Exists(data1))
                {
                    string content = File.ReadAllText(data1);
                    myDataGame = JsonUtility.FromJson<MyDataGame>(content);

                    PlayerPrefs.SetString("nivel1", myDataGame.lvl1);
                    PlayerPrefs.SetString("nivel2", myDataGame.lvl2);
                    PlayerPrefs.SetString("nivel3", myDataGame.lvl3);
                    PlayerPrefs.SetString("nivel4", myDataGame.lvl4);

                    PlayerPrefs.SetInt("SaveData", 3);

                    PlayerPrefs.SetInt("levelsUnlock", myDataGame.levelsUnlock);
                    Debug.Log("carga archivo 3");
                    SceneManager.LoadScene("StartMenu");
                }
                else
                {
                    Debug.Log("Archivo inexistente");
                }
                break;

            default:
                Debug.Log("No existe ese archivo");
                break;
        }      
    }
    #endregion

    #region SaveData
    public void SaveData()
    {
        int num = PlayerPrefs.GetInt("SaveData");
        switch (num)
        {
            case 1:

                MyDataGame newData1 = new MyDataGame()
                {
                    levelsUnlock = PlayerPrefs.GetInt("levelsUnlock"),
                    lvl1 = PlayerPrefs.GetString("nivel1"),
                    lvl2 = PlayerPrefs.GetString("nivel2"),
                    lvl3 = PlayerPrefs.GetString("nivel3"),
                    lvl4 = PlayerPrefs.GetString("nivel4")
                };

                string toJson1 = JsonUtility.ToJson(newData1);
                File.WriteAllText(data1, toJson1);

                Debug.Log("Guardado en archivo 1");

                break;

            case 2:

                MyDataGame newData2 = new MyDataGame()
                {
                    levelsUnlock = PlayerPrefs.GetInt("levelsUnlock"),
                    lvl1 = PlayerPrefs.GetString("nivel1"),
                    lvl2 = PlayerPrefs.GetString("nivel2"),
                    lvl3 = PlayerPrefs.GetString("nivel3"),
                    lvl4 = PlayerPrefs.GetString("nivel4")
                };

                string toJson2 = JsonUtility.ToJson(newData2);
                File.WriteAllText(data2, toJson2);

                Debug.Log("Guardado en archivo 2");

                break;

            case 3:

                MyDataGame newData3 = new MyDataGame()
                {
                    levelsUnlock = PlayerPrefs.GetInt("levelsUnlock"),
                    lvl1 = PlayerPrefs.GetString("nivel1"),
                    lvl2 = PlayerPrefs.GetString("nivel2"),
                    lvl3 = PlayerPrefs.GetString("nivel3"),
                    lvl4 = PlayerPrefs.GetString("nivel4")
                };

                string toJson3 = JsonUtility.ToJson(newData3);
                File.WriteAllText(data3, toJson3);

                Debug.Log("Guardado en archivo 3");

                break;

            default:
                Debug.Log("No estas guardando nada");
                break;
        }
    }
    #endregion

    #region deleteData
    public void deleteData(int num)
    {
        switch (num)
        {
            case 1:

                MyDataGame newData1 = new MyDataGame()
                {
                    levelsUnlock = 0,
                    lvl1 = "0",
                    lvl2 = "0",
                    lvl3 = "0",
                    lvl4 = "0"
                };

                string toJson1 = JsonUtility.ToJson(newData1);
                File.WriteAllText(data1, toJson1);

                Debug.Log("Guardado en archivo 1");

                break;

            case 2:

                MyDataGame newData2 = new MyDataGame()
                {
                    levelsUnlock = 0,
                    lvl1 = "0",
                    lvl2 = "0",
                    lvl3 = "0",
                    lvl4 = "0"
                };

                string toJson2 = JsonUtility.ToJson(newData2);
                File.WriteAllText(data2, toJson2);

                Debug.Log("Guardado en archivo 2");

                break;

            case 3:

                MyDataGame newData3 = new MyDataGame()
                {
                    levelsUnlock = 0,
                    lvl1 = "0",
                    lvl2 = "0",
                    lvl3 = "0",
                    lvl4 = "0"
                };

                string toJson3 = JsonUtility.ToJson(newData3);
                File.WriteAllText(data3, toJson3);

                Debug.Log("Guardado en archivo 3");

                break;

            default:
                Debug.Log("No estas guardando nada");
                break;
        }
    }
    #endregion

    #region prefs
    private void PrefsCreator()
    {
        if (!PlayerPrefs.HasKey("nivel1"))
        {
            PlayerPrefs.SetString("nivel1", "0");
        }

        if (!PlayerPrefs.HasKey("nivel2"))
        {
            PlayerPrefs.SetString("nivel2", "0");
        }

        if (!PlayerPrefs.HasKey("nivel3"))
        {
            PlayerPrefs.SetString("nivel3", "0");
        }

        if (!PlayerPrefs.HasKey("nivel4"))
        {
            PlayerPrefs.SetString("nivel4", "0");
        }

        if (!PlayerPrefs.HasKey("SaveData"))
        {
            PlayerPrefs.SetInt("SaveData", 0);
        }
    }
    #endregion
}
