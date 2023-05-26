namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public static class MoveToMathControlConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.MoveToMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXW.MoveToMathControl openXmlElement, DMW.RunProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetRunProperties(DXW.MoveToMathControl openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.InsertedMathControl? GetInsertedMathControl(DXW.MoveToMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedMathControl>();
    if (element != null)
      return DMXW.InsertedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedMathControl(DXW.MoveToMathControl openXmlElement, DMW.InsertedMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.InsertedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedMathControl>(), value, diffs, objName, propName);
  }
  
  private static void SetInsertedMathControl(DXW.MoveToMathControl openXmlElement, DMW.InsertedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsertedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.InsertedMathControlConverter.CreateOpenXmlElement<DXW.InsertedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXW.MoveToMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (element != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedMathControl(DXW.MoveToMathControl openXmlElement, DMW.DeletedMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DeletedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedMathControl>(), value, diffs, objName, propName);
  }
  
  private static void SetDeletedMathControl(DXW.MoveToMathControl openXmlElement, DMW.DeletedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedMathControlConverter.CreateOpenXmlElement<DXW.DeletedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.MoveToMathControl? CreateModelElement(DXW.MoveToMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MoveToMathControl();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.MoveToMathControl? openXmlElement, DMW.MoveToMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName, propName))
        ok = false;
      if (!CmpInsertedMathControl(openXmlElement, value.InsertedMathControl, diffs, objName, propName))
        ok = false;
      if (!CmpDeletedMathControl(openXmlElement, value.DeletedMathControl, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MoveToMathControl value)
    where OpenXmlElementType: DXW.MoveToMathControl, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.MoveToMathControl openXmlElement, DMW.MoveToMathControl value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
    SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
    SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
  }
}
