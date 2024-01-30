using UnityEngine;

public class ColorIdBehavior2022 : IdContainerBehavior
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}