namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public static class FractionPropertiesConverter
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  private static DMMath.FractionKind? GetFractionType(DXMath.FractionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.FractionTypeValues, DMMath.FractionKind>(openXmlElement.GetFirstChild<DXMath.FractionType>()?.Val?.Value);
  }
  
  private static bool CmpFractionType(DXMath.FractionProperties openXmlElement, DMMath.FractionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.FractionTypeValues, DMMath.FractionKind>(openXmlElement.GetFirstChild<DXMath.FractionType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetFractionType(DXMath.FractionProperties openXmlElement, DMMath.FractionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.FractionType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.FractionTypeValues, DMMath.FractionKind>(itemElement, (DMMath.FractionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.FractionType, DocumentFormat.OpenXml.Math.FractionTypeValues, DMMath.FractionKind>((DMMath.FractionKind)value));
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.FractionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.FractionProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXMath.FractionProperties openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.FractionProperties? CreateModelElement(DXMath.FractionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.FractionProperties();
      value.FractionType = GetFractionType(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.FractionProperties? openXmlElement, DMMath.FractionProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFractionType(openXmlElement, value.FractionType, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.FractionProperties value)
    where OpenXmlElementType: DXMath.FractionProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.FractionProperties openXmlElement, DMMath.FractionProperties value)
  {
    SetFractionType(openXmlElement, value?.FractionType);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
