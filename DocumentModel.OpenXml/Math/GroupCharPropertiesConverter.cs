namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.GroupCharProperties"/> class from/to OpenXml converter.
/// </summary>
public static class GroupCharPropertiesConverter
{
  #region Group Character (Grouping Character). conversion.
  private static String? GetAccentChar(DXM.GroupCharProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.AccentChar>()?.Val);
  }
  
  private static bool CmpAccentChar(DXM.GroupCharProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.AccentChar>()?.Val, value, diffs, objName, "Operator");
  }
  
  private static void SetAccentChar(DXM.GroupCharProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXM.AccentChar>(openXmlElement, value);
  }
  #endregion

  #region Position (Group Character) conversion.
  private static DMM.VerticalJustificationKind? GetPosition(DXM.GroupCharProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXM.Position>()?.Val?.Value);
  }
  
  private static bool CmpPosition(DXM.GroupCharProperties openXmlElement, DMM.VerticalJustificationKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXM.Position>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPosition(DXM.GroupCharProperties openXmlElement, DMM.VerticalJustificationKind? value)
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

  #region Vertical Justification conversion.
  private static DMM.VerticalJustificationKind? GetVerticalJustification(DXM.GroupCharProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXM.VerticalJustification>()?.Val?.Value);
  }
  
  private static bool CmpVerticalJustification(DXM.GroupCharProperties openXmlElement, DMM.VerticalJustificationKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXM.VerticalJustification>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVerticalJustification(DXM.GroupCharProperties openXmlElement, DMM.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.VerticalJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>(itemElement, (DMM.VerticalJustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.VerticalJustification, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMM.VerticalJustificationKind>((DMM.VerticalJustificationKind)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.GroupCharProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.GroupCharProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetControlProperties(DXM.GroupCharProperties openXmlElement, DMM.ControlProperties? value)
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

  #region GroupCharProperties model conversion.
  public static DMM.GroupCharProperties? CreateModelElement(DXM.GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.GroupCharProperties();
      model.AccentChar = GetAccentChar(openXmlElement);
      model.Position = GetPosition(openXmlElement);
      model.VerticalJustification = GetVerticalJustification(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.GroupCharProperties? openXmlElement, DMM.GroupCharProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAccentChar(openXmlElement, model.AccentChar, diffs, objName, propName))
        ok = false;
      if (!CmpPosition(openXmlElement, model.Position, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalJustification(openXmlElement, model.VerticalJustification, diffs, objName, propName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.GroupCharProperties model)
    where OpenXmlElementType: DXM.GroupCharProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.GroupCharProperties openXmlElement, DMM.GroupCharProperties model)
  {
    SetAccentChar(openXmlElement, model?.AccentChar);
    SetPosition(openXmlElement, model?.Position);
    SetVerticalJustification(openXmlElement, model?.VerticalJustification);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
