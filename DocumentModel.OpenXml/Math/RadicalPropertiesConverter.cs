namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Radical Properties.
/// </summary>
public static class RadicalPropertiesConverter
{
  /// <summary>
  /// Hide Degree.
  /// </summary>
  private static DMMath.BooleanKind? GetHideDegree(DXMath.RadicalProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideDegree>()?.Val?.Value);
  }
  
  private static bool CmpHideDegree(DXMath.RadicalProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HideDegree>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHideDegree(DXMath.RadicalProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideDegree>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.HideDegree, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.RadicalProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.RadicalProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlProperties(DXMath.RadicalProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DocumentModel.Math.RadicalProperties? CreateModelElement(DXMath.RadicalProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.RadicalProperties();
      value.HideDegree = GetHideDegree(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.RadicalProperties? openXmlElement, DMMath.RadicalProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHideDegree(openXmlElement, value.HideDegree, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.RadicalProperties value)
    where OpenXmlElementType: DXMath.RadicalProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.RadicalProperties openXmlElement, DMMath.RadicalProperties value)
  {
    SetHideDegree(openXmlElement, value?.HideDegree);
    SetControlProperties(openXmlElement, value?.ControlProperties);
    }
  }
