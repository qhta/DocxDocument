namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  /// Border Style
  /// </summary>
  private static DMWVml.BorderKind? GetType(DXVmlW.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DMWVml.BorderKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVmlW.BorderType openXmlElement, DMWVml.BorderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DMWVml.BorderKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXVmlW.BorderType openXmlElement, DMWVml.BorderKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DMWVml.BorderKind>(value);
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  private static Int64? GetWidth(DXVmlW.BorderType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static bool CmpWidth(DXVmlW.BorderType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Width?.Value == value;
  }
  
  private static void SetWidth(DXVmlW.BorderType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  private static Boolean? GetShadow(DXVmlW.BorderType openXmlElement)
  {
    return openXmlElement?.Shadow?.Value;
  }
  
  private static bool CmpShadow(DXVmlW.BorderType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Shadow?.Value == value;
  }
  
  private static void SetShadow(DXVmlW.BorderType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Shadow = value;
    else
      openXmlElement.Shadow = null;
  }
  
  public static DMWVml.BorderType? CreateModelElement(DXVmlW.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWVml.BorderType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlW.BorderType? openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWVml.BorderType? value)
    where OpenXmlElementType: DXVmlW.BorderType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetWidth(openXmlElement, value?.Width);
      SetShadow(openXmlElement, value?.Shadow);
      return openXmlElement;
    }
    return default;
  }
}
