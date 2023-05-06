namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.SubscriptProperties"/> class from/to OpenXml converter.
/// </summary>
public static class SubscriptPropertiesConverter
{
  #region ControlProperties. conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.SubscriptProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.SubscriptProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.SubscriptProperties openXmlElement, DMM.ControlProperties? value)
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

  #region SubscriptProperties model conversion.
  public static DMM.SubscriptProperties? CreateModelElement(DXM.SubscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.SubscriptProperties();
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.SubscriptProperties? openXmlElement, DMM.SubscriptProperties? model, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.SubscriptProperties model)
    where OpenXmlElementType: DXM.SubscriptProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.SubscriptProperties openXmlElement, DMM.SubscriptProperties model)
  {
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
