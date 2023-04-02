namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Control Properties.
/// </summary>
public static class ControlPropertiesConverter
{
  private static DMW.RunProperties? GetRunProperties(DXMath.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXMath.ControlProperties openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName);
  }
  
  private static void SetRunProperties(DXMath.ControlProperties openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.InsertedMathControl? GetInsertedMathControl(DXMath.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedMathControl>();
    if (element != null)
      return DMXW.InsertedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedMathControl(DXMath.ControlProperties openXmlElement, DMW.InsertedMathControl? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedMathControl>(), value, diffs, objName);
  }
  
  private static void SetInsertedMathControl(DXMath.ControlProperties openXmlElement, DMW.InsertedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsertedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.InsertedMathControlConverter.CreateOpenXmlElement<DXW.InsertedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXMath.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (element != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedMathControl(DXMath.ControlProperties openXmlElement, DMW.DeletedMathControl? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedMathControl>(), value, diffs, objName);
  }
  
  private static void SetDeletedMathControl(DXMath.ControlProperties openXmlElement, DMW.DeletedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedMathControlConverter.CreateOpenXmlElement<DXW.DeletedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromMathControl? GetMoveFromMathControl(DXMath.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromMathControl>();
    if (element != null)
      return DMXW.MoveFromMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromMathControl(DXMath.ControlProperties openXmlElement, DMW.MoveFromMathControl? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromMathControl>(), value, diffs, objName);
  }
  
  private static void SetMoveFromMathControl(DXMath.ControlProperties openXmlElement, DMW.MoveFromMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveFromMathControlConverter.CreateOpenXmlElement<DXW.MoveFromMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToMathControl? GetMoveToMathControl(DXMath.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToMathControl>();
    if (element != null)
      return DMXW.MoveToMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToMathControl(DXMath.ControlProperties openXmlElement, DMW.MoveToMathControl? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToMathControl>(), value, diffs, objName);
  }
  
  private static void SetMoveToMathControl(DXMath.ControlProperties openXmlElement, DMW.MoveToMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveToMathControlConverter.CreateOpenXmlElement<DXW.MoveToMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.ControlProperties? CreateModelElement(DXMath.ControlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.ControlProperties();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      value.MoveFromMathControl = GetMoveFromMathControl(openXmlElement);
      value.MoveToMathControl = GetMoveToMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.ControlProperties? openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
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
      if (!CmpMoveFromMathControl(openXmlElement, value.MoveFromMathControl, diffs, objName))
        ok = false;
      if (!CmpMoveToMathControl(openXmlElement, value.MoveToMathControl, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.ControlProperties value)
    where OpenXmlElementType: DXMath.ControlProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.ControlProperties openXmlElement, DMMath.ControlProperties value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
    SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
    SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
    SetMoveFromMathControl(openXmlElement, value?.MoveFromMathControl);
    SetMoveToMathControl(openXmlElement, value?.MoveToMathControl);
  }
}
