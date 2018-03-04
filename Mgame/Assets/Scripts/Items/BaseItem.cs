using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eItemType
{
    None,
    Gold,//金矿

}

public class BaseItem : MonoBehaviour {

    public eItemType ItemType = eItemType.None;
    public ConfigItems ItemConfig = null;

    public int ItemID = 0;

	// Use this for initialization
	void Start () {
        
	}

    public virtual void Init()
    {
        ItemConfig = ConfigItems.GetByKey(ItemID);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
