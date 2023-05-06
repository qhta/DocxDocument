namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MoveFromMathControl Class.
/// </summary>
public static class MoveFromMathControlConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.MoveFromMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXW.MoveFromMathControl openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName);
  }
  
  private static void SetRunProperties(DXW.MoveFromMathControl openXmlElement, DMW.RunProperties? value)
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
  
  private static DMW.InsertedMathControl? GetInsertedMathControl(DXW.MoveFromMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedMathControl>();
    if (element != null)
      return DMXW.InsertedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedMathControl(DXW.MoveFromMathControl openXmlElement, DMW.InsertedMathControl? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedMathControl>(), value, diffs, objName);
  }
  
  private static void SetInsertedMathControl(DXW.MoveFromMathControl openXmlElement, DMW.InsertedMathControl? value)
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
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXW.MoveFromMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (element != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedMathControl(DXW.MoveFromMathControl openXmlElement, DMW.DeletedMathControl? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedMathControl>(), value, diffs, objName);
  }
  
  private static void SetDeletedMathControl(DXW.MoveFromMathControl openXmlElement, DMW.DeletedMathControl? value)
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
  
  public static DMW.MoveFromMathControl? CreateModelElement(DXW.MoveFromMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MoveFromMathControl();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.MoveFromMathControl? openXmlElement, DMW.MoveFromMathControl? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      if (!CmpInsertedMathControl(openXmlElement, value.InsertedMathControl, diffs, objName))
        ok = false;
      if (!CmpDeletedMathControl(openXmlElement, value.DeletedMathControl, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MoveFromMathControl value)
    where OpenXmlElementType: DXW.MoveFromMathControl, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.MoveFromMathControl openXmlElement, DMW.MoveFromMathControl value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
    SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
    SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
  }
}
