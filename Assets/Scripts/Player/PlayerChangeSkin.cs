using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeSkin : NghiaMonoBehaviour
{
    #region skin
    [SerializeField]
    private List<GameObject> listSkin = new List<GameObject>();
    public List<GameObject> ListSkin { get { return listSkin; } }

    [SerializeField]
    private List<GameObject> listWeapon = new List<GameObject>();
    public List<GameObject> ListWeapon { get { return listWeapon; } }
    #endregion
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeModelWeapon(string name, int n)
    {
        for (int i = 0; i < listWeapon.Count; i++)
        {
            listWeapon[i].SetActive(false);
            if (listWeapon[i].name == (name + n))
            {
                listWeapon[i].SetActive(true);
                break;
            }
        }
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        GameObject model = transform.parent.Find("Model").gameObject;
        loadGameObject(model, listSkin, "Belt", 3);
        loadGameObject(model, listSkin, "Cloth", 7);
        loadGameObject(model, listSkin, "Crown", 4);
        loadGameObject(model, listSkin, "Face", 3);
        loadGameObject(model, listSkin, "Glove", 6);
        loadGameObject(model, listSkin, "Hair", 5);
        loadGameObject(model, listSkin, "HairHalf", 5);
        loadGameObject(model, listSkin, "Hat", 3);
        loadGameObject(model, listSkin, "Helm", 7);
        loadGameObject(model, listSkin, "Shoe", 6);
        loadGameObject(model, listSkin, "ShoulderPad", 6);
        model = model.transform.Find("root").gameObject;
        model = model.transform.GetChild(1).gameObject;
        loadGameObject(model, listWeapon, "Axe_L", 1);
        loadGameObject(model, listWeapon, "Bow", 2);
        loadGameObject(model, listWeapon, "Hammer_L", 1);
        loadGameObject(model, listWeapon, "Shield", 5);
        loadGameObject(model, listWeapon, "Sword_L", 4);
        loadGameObject(model, listWeapon, "Wand_L", 2);
        model = model.transform.parent.GetChild(2).gameObject;
        loadGameObject(model, listWeapon, "Arrow", 2);
        loadGameObject(model, listWeapon, "Axe_R", 1);
        loadGameObject(model, listWeapon, "Sword_R", 4);
        loadGameObject(model, listWeapon, "Wand_R", 2);
        model = model.transform.parent.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).gameObject;
        loadGameObject(model, listSkin, "BackPack", 3);
    }
    private void loadGameObject(GameObject model, List<GameObject> gameObjects, string modelName, int n)
    {

        for (int i = 0; i < n; i++)
        {
            gameObjects.Add(model.transform.Find(modelName + (i + 1)).gameObject);
        }
    }
}
