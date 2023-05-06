namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.DelimiterProperties"/> class from/to OpenXml converter.
/// </summary>
public static class DelimiterPropertiesConverter
{
  #region Delimiter Beginning Character conversion.
  private static String? GetBeginChar(DXM.DelimiterProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.BeginChar>()?.Val);
  }
  
  private static bool CmpBeginChar(DXM.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.BeginChar>()?.Val, value, diffs, objName, "BeginChar");
  }
  
  private static void SetBeginChar(DXM.DelimiterProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXM.BeginChar>(openXmlElement, value);
  }
  #endregion

  #region Delimiter Separator Character conversion.
  private static String? GetSeparatorChar(DXM.DelimiterProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.SeparatorChar>()?.Val);
  }
  
  private static bool CmpSeparatorChar(DXM.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.SeparatorChar>()?.Val, value, diffs, objName, "SeparatorChar");
  }
  
  private static void SetSeparatorChar(DXM.DelimiterProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXM.SeparatorChar>(openXmlElement, value);
  }
  #endregion

  #region Delimiter Ending Character conversion.
  private static String? GetEndChar(DXM.DelimiterProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.EndChar>()?.Val);
  }
  
  private static bool CmpEndChar(DXM.DelimiterProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.EndChar>()?.Val, value, diffs, objName, "EndChar");
  }
  
  private static void SetEndChar(DXM.DelimiterProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXM.EndChar>(openXmlElement, value);
  }
  #endregion

  #region Delimiter Grow conversion.
  private static bool? GetGrowOperators(DXM.DelimiterProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.GrowOperators>()?.Val?.Value);
  }
  
  private static bool CmpGrowOperators(DXM.DelimiterProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.GrowOperators>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetGrowOperators(DXM.DelimiterProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.GrowOperators>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.GrowOperators>((bool)value));
  }
  #endregion

  #region Shape (Delimiters) conversion.
  private static DMM.ShapeDelimiterKind? GetShape(DXM.DelimiterProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>(openXmlElement.GetFirstChild<DXM.Shape>()?.Val?.Value);
  }
  
  private static bool CmpShape(DXM.DelimiterProperties openXmlElement, DMM.ShapeDelimiterKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>(openXmlElement.GetFirstChild<DXM.Shape>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetShape(DXM.DelimiterProperties openXmlElement, DMM.ShapeDelimiterKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Shape>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>(itemElement, (DMM.ShapeDelimiterKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.Shape, DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>((DMM.ShapeDelimiterKind)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.DelimiterProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.DelimiterProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.DelimiterProperties openXmlElement, DMM.ControlProperties? value)
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

  #region DelimiterProperties model conversion.
  public static DMM.DelimiterProperties? CreateModelElement(DXM.DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.DelimiterProperties();
      model.BeginChar = GetBeginChar(openXmlElement);
      model.SeparatorChar = GetSeparatorChar(openXmlElement);
      model.EndChar = GetEndChar(openXmlElement);
      model.GrowOperators = GetGrowOperators(openXmlElement);
      model.Shape = GetShape(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.DelimiterProperties? openXmlElement, DMM.DelimiterProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBeginChar(openXmlElement, model.BeginChar, diffs, objName))
        ok = false;
      if (!CmpSeparatorChar(openXmlElement, model.SeparatorChar, diffs, objName))
        ok = false;
      if (!CmpEndChar(openXmlElement, model.EndChar, diffs, objName))
        ok = false;
      if (!CmpGrowOperators(openXmlElement, model.GrowOperators, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, model.Shape, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.DelimiterProperties model)
    where OpenXmlElementType: DXM.DelimiterProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.DelimiterProperties openXmlElement, DMM.DelimiterProperties model)
  {
    SetBeginChar(openXmlElement, model?.BeginChar);
    SetSeparatorChar(openXmlElement, model?.SeparatorChar);
    SetEndChar(openXmlElement, model?.EndChar);
    SetGrowOperators(openXmlElement, model?.GrowOperators);
    SetShape(openXmlElement, model?.Shape);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
