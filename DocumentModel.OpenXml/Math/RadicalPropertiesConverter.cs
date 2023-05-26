namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.RadicalProperties"/> class from/to OpenXml converter.
/// </summary>
public static class RadicalPropertiesConverter
{
  #region Hide Degree. conversion.
  private static bool? GetHideDegree(DXM.RadicalProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HideDegree>()?.Val?.Value);
  }
  
  private static bool CmpHideDegree(DXM.RadicalProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HideDegree>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHideDegree(DXM.RadicalProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HideDegree>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HideDegree>((bool)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.RadicalProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.RadicalProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetControlProperties(DXM.RadicalProperties openXmlElement, DMM.ControlProperties? value)
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

  #region RadicalProperties model conversion.
  public static DMM.RadicalProperties? CreateModelElement(DXM.RadicalProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.RadicalProperties();
      model.HideDegree = GetHideDegree(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.RadicalProperties? openXmlElement, DMM.RadicalProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpHideDegree(openXmlElement, model.HideDegree, diffs, objName, propName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.RadicalProperties model)
    where OpenXmlElementType: DXM.RadicalProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.RadicalProperties openXmlElement, DMM.RadicalProperties model)
  {
    SetHideDegree(openXmlElement, model?.HideDegree);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
