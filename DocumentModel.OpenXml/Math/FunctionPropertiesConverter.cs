namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.FunctionProperties"/> class from/to OpenXml converter.
/// </summary>
public static class FunctionPropertiesConverter
{
  #region ControlProperties. conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.FunctionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.FunctionProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.FunctionProperties openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region FunctionProperties model conversion.
  public static DMM.FunctionProperties? CreateModelElement(DXM.FunctionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.FunctionProperties();
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.FunctionProperties? openXmlElement, DMM.FunctionProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.FunctionProperties model)
    where OpenXmlElementType: DXM.FunctionProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.FunctionProperties openXmlElement, DMM.FunctionProperties model)
  {
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
