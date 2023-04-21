namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public static class LinearShadePropertiesConverter
{
  /// <summary>
  /// ang, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetAngle(DXO10W.LinearShadeProperties openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  private static bool CmpAngle(DXO10W.LinearShadeProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Angle?.Value == value) return true;
    diffs?.Add(objName, "Angle", openXmlElement?.Angle?.Value, value);
    return false;
  }
  
  private static void SetAngle(DXO10W.LinearShadeProperties openXmlElement, Int32? value)
  {
    openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.OnOffKind? GetScaled(DXO10W.LinearShadeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement?.Scaled?.Value);
  }
  
  private static bool CmpScaled(DXO10W.LinearShadeProperties openXmlElement, DMW.OnOffKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement?.Scaled?.Value, value, diffs, objName);
  }
  
  private static void SetScaled(DXO10W.LinearShadeProperties openXmlElement, DMW.OnOffKind? value)
  {
    openXmlElement.Scaled = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(value);
  }
  
  public static DMW.LinearShadeProperties? CreateModelElement(DXO10W.LinearShadeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LinearShadeProperties();
      value.Angle = GetAngle(openXmlElement);
      value.Scaled = GetScaled(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.LinearShadeProperties? openXmlElement, DMW.LinearShadeProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName))
        ok = false;
      if (!CmpScaled(openXmlElement, value.Scaled, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LinearShadeProperties value)
    where OpenXmlElementType: DXO10W.LinearShadeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.LinearShadeProperties openXmlElement, DMW.LinearShadeProperties value)
  {
    SetAngle(openXmlElement, value?.Angle);
    SetScaled(openXmlElement, value?.Scaled);
  }
}
