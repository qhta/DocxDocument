namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Accent"/> class from/to OpenXml converter.
/// </summary>
public static class AccentPropertiesConverter
{
  #region Accent Character conversion.
  private static String? GetAccentChar(DXM.AccentProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.AccentChar>()?.Val);
  }
  
  private static bool CmpAccentChar(DXM.AccentProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.AccentChar>()?.Val, value, diffs, objName, "Operator");
  }
  
  private static void SetAccentChar(DXM.AccentProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXM.AccentChar>(openXmlElement, value);
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.AccentProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.AccentProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetControlProperties(DXM.AccentProperties openXmlElement, DMM.ControlProperties? value)
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

  #region AccentProperties model conversion.
  public static DMM.AccentProperties? CreateModelElement(DXM.AccentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMM.AccentProperties();
      value.AccentChar = GetAccentChar(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  #endregion

  #region AccentProperties model conversion.
  public static bool CompareModelElement(DXM.AccentProperties? openXmlElement, DMM.AccentProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAccentChar(openXmlElement, model.AccentChar, diffs, objName, propName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.AccentProperties model)
    where OpenXmlElementType: DXM.AccentProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.AccentProperties openXmlElement, DMM.AccentProperties model)
  {
    SetAccentChar(openXmlElement, model?.AccentChar);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
