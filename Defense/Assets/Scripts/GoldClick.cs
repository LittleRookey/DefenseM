using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        DataController.Instance.gold += DataController.Instance.goldPerClick;
    }

}
