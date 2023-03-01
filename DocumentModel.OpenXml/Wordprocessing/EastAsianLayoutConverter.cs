namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public static class EastAsianLayoutConverter
{
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  private static Int32? GetId(DXW.EastAsianLayout openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.EastAsianLayout openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.EastAsianLayout openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  private static Boolean? GetCombine(DXW.EastAsianLayout openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Combine);
  }
  
  private static bool CmpCombine(DXW.EastAsianLayout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Combine, value, diffs, objName, "Combine");
  }
  
  private static void SetCombine(DXW.EastAsianLayout openXmlElement, Boolean? value)
  {
    openXmlElement.Combine = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  private static DMW.CombineBracketKind? GetCombineBrackets(DXW.EastAsianLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DMW.CombineBracketKind>(openXmlElement?.CombineBrackets?.Value);
  }
  
  private static bool CmpCombineBrackets(DXW.EastAsianLayout openXmlElement, DMW.CombineBracketKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DMW.CombineBracketKind>(openXmlElement?.CombineBrackets?.Value, value, diffs, objName);
  }
  
  private static void SetCombineBrackets(DXW.EastAsianLayout openXmlElement, DMW.CombineBracketKind? value)
  {
    openXmlElement.CombineBrackets = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DMW.CombineBracketKind>(value);
  }
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  private static Boolean? GetVertical(DXW.EastAsianLayout openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Vertical);
  }
  
  private static bool CmpVertical(DXW.EastAsianLayout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Vertical, value, diffs, objName, "Vertical");
  }
  
  private static void SetVertical(DXW.EastAsianLayout openXmlElement, Boolean? value)
  {
    openXmlElement.Vertical = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  private static Boolean? GetVerticalCompress(DXW.EastAsianLayout openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.VerticalCompress);
  }
  
  private static bool CmpVerticalCompress(DXW.EastAsianLayout openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.VerticalCompress, value, diffs, objName, "VerticalCompress");
  }
  
  private static void SetVerticalCompress(DXW.EastAsianLayout openXmlElement, Boolean? value)
  {
    openXmlElement.VerticalCompress = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.EastAsianLayout? CreateModelElement(DXW.EastAsianLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.EastAsianLayout();
      value.Id = GetId(openXmlElement);
      value.Combine = GetCombine(openXmlElement);
      value.CombineBrackets = GetCombineBrackets(openXmlElement);
      value.Vertical = GetVertical(openXmlElement);
      value.VerticalCompress = GetVerticalCompress(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.EastAsianLayout? openXmlElement, DMW.EastAsianLayout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpCombine(openXmlElement, value.Combine, diffs, objName))
        ok = false;
      if (!CmpCombineBrackets(openXmlElement, value.CombineBrackets, diffs, objName))
        ok = false;
      if (!CmpVertical(openXmlElement, value.Vertical, diffs, objName))
        ok = false;
      if (!CmpVerticalCompress(openXmlElement, value.VerticalCompress, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.EastAsianLayout value)
    where OpenXmlElementType: DXW.EastAsianLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.EastAsianLayout openXmlElement, DMW.EastAsianLayout value)
  {
    SetId(openXmlElement, value?.Id);
    SetCombine(openXmlElement, value?.Combine);
    SetCombineBrackets(openXmlElement, value?.CombineBrackets);
    SetVertical(openXmlElement, value?.Vertical);
    SetVerticalCompress(openXmlElement, value?.VerticalCompress);
  }
}
