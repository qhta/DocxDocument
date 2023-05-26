namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.SuperscriptProperties"/> class from/to OpenXml converter.
/// </summary>
public static class SuperscriptPropertiesConverter
{
  #region ControlProperties. conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.SuperscriptProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.SuperscriptProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetControlProperties(DXM.SuperscriptProperties openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region SuperscriptProperties model conversion.
  public static DMM.SuperscriptProperties? CreateModelElement(DXM.SuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.SuperscriptProperties();
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.SuperscriptProperties? openXmlElement, DMM.SuperscriptProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.SuperscriptProperties model)
    where OpenXmlElementType: DXM.SuperscriptProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.SuperscriptProperties openXmlElement, DMM.SuperscriptProperties model)
  {
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
