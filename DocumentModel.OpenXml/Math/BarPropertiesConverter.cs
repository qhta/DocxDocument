namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.BarProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BarPropertiesConverter
{
  #region Position (Bar). conversion.
  private static DMM.VerticalJustificationKind? GetPosition(DXM.BarProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXM.Position>()?.Val?.Value);
  }
  
  private static bool CmpPosition(DXM.BarProperties openXmlElement, DMM.VerticalJustificationKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXM.Position>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPosition(DXM.BarProperties openXmlElement, DMM.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Position>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(itemElement, (DMM.VerticalJustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.Position, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>((DMM.VerticalJustificationKind)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.BarProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.BarProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetControlProperties(DXM.BarProperties openXmlElement, DMM.ControlProperties? value)
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

  #region BarProperties model conversion.
  public static DMM.BarProperties? CreateModelElement(DXM.BarProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMM.BarProperties();
      value.Position = GetPosition(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.BarProperties? openXmlElement, DMM.BarProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName, propName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.BarProperties value)
    where OpenXmlElementType: DXM.BarProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.BarProperties openXmlElement, DMM.BarProperties value)
  {
    SetPosition(openXmlElement, value?.Position);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
  #endregion
}
