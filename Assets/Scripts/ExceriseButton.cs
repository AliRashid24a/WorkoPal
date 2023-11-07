using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ExceriseButton : MonoBehaviour
{
    public GameObject counter;
    public GameObject parent;
    private TextMeshProUGUI exName;
    public Button button;

    void Start()
    {
        exName = GetComponentInChildren<TextMeshProUGUI>();
        Button butt = button.GetComponent<Button>();
        butt.onClick.AddListener(StartExercise);
        parent = GameObject.Find("Main Canvas/CounterParent");
        List<GameObject> allChildren = GetAllChildren(parent);
        foreach (GameObject child in allChildren)
        {
            if (child.name == "Counter")
            {
                counter = child;
            }
        }
    }
    public void StartExercise()
    {
        counter.SetActive(true);
        CounterManager.Instance.ResetCounter();
        CounterManager.Instance.SetExerciseName(exName.text);
    }


    public List<GameObject> GetAllChildren(GameObject obj)
    {
        List<GameObject> children = new List<GameObject>();

        foreach(Transform child in obj.transform)
        {
            children.Add(child.gameObject);
        }
        return children;
    }
}
