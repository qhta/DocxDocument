namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.ControlProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ControlPropertiesConverter
{
  #region RunProperties conversion.
  private static DMW.RunProperties? GetRunProperties(DXM.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXM.ControlProperties openXmlElement, DMW.RunProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetRunProperties(DXM.ControlProperties openXmlElement, DMW.RunProperties? value)
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
  
  private static DMW.InsertedMathControl? GetInsertedMathControl(DXM.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedMathControl>();
    if (element != null)
      return DMXW.InsertedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedMathControl(DXM.ControlProperties openXmlElement, DMW.InsertedMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.InsertedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedMathControl>(), value, diffs, objName, propName);
  }
  
  private static void SetInsertedMathControl(DXM.ControlProperties openXmlElement, DMW.InsertedMathControl? value)
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
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXM.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (element != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedMathControl(DXM.ControlProperties openXmlElement, DMW.DeletedMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DeletedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedMathControl>(), value, diffs, objName, propName);
  }
  
  private static void SetDeletedMathControl(DXM.ControlProperties openXmlElement, DMW.DeletedMathControl? value)
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
  
  private static DMW.MoveFromMathControl? GetMoveFromMathControl(DXM.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromMathControl>();
    if (element != null)
      return DMXW.MoveFromMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromMathControl(DXM.ControlProperties openXmlElement, DMW.MoveFromMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.MoveFromMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromMathControl>(), value, diffs, objName, propName);
  }
  
  private static void SetMoveFromMathControl(DXM.ControlProperties openXmlElement, DMW.MoveFromMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveFromMathControlConverter.CreateOpenXmlElement<DXW.MoveFromMathControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.MoveToMathControl? GetMoveToMathControl(DXM.ControlProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToMathControl>();
    if (element != null)
      return DMXW.MoveToMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToMathControl(DXM.ControlProperties openXmlElement, DMW.MoveToMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.MoveToMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToMathControl>(), value, diffs, objName, propName);
  }
  
  private static void SetMoveToMathControl(DXM.ControlProperties openXmlElement, DMW.MoveToMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveToMathControlConverter.CreateOpenXmlElement<DXW.MoveToMathControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ControlProperties model conversion.
  public static DMM.ControlProperties? CreateModelElement(DXM.ControlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.ControlProperties();
      model.RunProperties = GetRunProperties(openXmlElement);
      model.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      model.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      model.MoveFromMathControl = GetMoveFromMathControl(openXmlElement);
      model.MoveToMathControl = GetMoveToMathControl(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.ControlProperties? openXmlElement, DMM.ControlProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpRunProperties(openXmlElement, model.RunProperties, diffs, objName, propName))
        ok = false;
      if (!CmpInsertedMathControl(openXmlElement, model.InsertedMathControl, diffs, objName, propName))
        ok = false;
      if (!CmpDeletedMathControl(openXmlElement, model.DeletedMathControl, diffs, objName, propName))
        ok = false;
      if (!CmpMoveFromMathControl(openXmlElement, model.MoveFromMathControl, diffs, objName, propName))
        ok = false;
      if (!CmpMoveToMathControl(openXmlElement, model.MoveToMathControl, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.ControlProperties model)
    where OpenXmlElementType: DXM.ControlProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.ControlProperties openXmlElement, DMM.ControlProperties model)
  {
    SetRunProperties(openXmlElement, model?.RunProperties);
    SetInsertedMathControl(openXmlElement, model?.InsertedMathControl);
    SetDeletedMathControl(openXmlElement, model?.DeletedMathControl);
    SetMoveFromMathControl(openXmlElement, model?.MoveFromMathControl);
    SetMoveToMathControl(openXmlElement, model?.MoveToMathControl);
  }
  #endregion
}
