namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  /// Border Style
  /// </summary>
  private static DMWV.BorderKind? GetType(DXVW.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DMWV.BorderKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXVW.BorderType openXmlElement, DMWV.BorderKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DMWV.BorderKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXVW.BorderType openXmlElement, DMWV.BorderKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues, DMWV.BorderKind>(value);
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  private static Int64? GetWidth(DXVW.BorderType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXVW.BorderType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXVW.BorderType openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  private static Boolean? GetShadow(DXVW.BorderType openXmlElement)
  {
    return openXmlElement?.Shadow?.Value;
  }
  
  private static bool CmpShadow(DXVW.BorderType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Shadow?.Value == value) return true;
    diffs?.Add(objName, "Shadow", openXmlElement?.Shadow?.Value, value);
    return false;
  }
  
  private static void SetShadow(DXVW.BorderType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Shadow = value;
    else
      openXmlElement.Shadow = null;
  }
  
  public static DMW.Vml.BorderType? CreateModelElement(DXVW.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Vml.BorderType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVW.BorderType? openXmlElement, DMWV.BorderType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName, propName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWV.BorderType value)
    where OpenXmlElementType: DXVW.BorderType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVW.BorderType openXmlElement, DMWV.BorderType value)
  {
    SetType(openXmlElement, value?.Type);
    SetWidth(openXmlElement, value?.Width);
    SetShadow(openXmlElement, value?.Shadow);
  }
}
