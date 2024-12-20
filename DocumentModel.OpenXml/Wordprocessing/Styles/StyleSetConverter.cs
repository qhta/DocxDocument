namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public static class StyleSetConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetId(DXO10W.StyleSet openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO10W.StyleSet openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO10W.StyleSet openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.OnOffKind? GetVal(DXO10W.StyleSet openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXO10W.StyleSet openXmlElement, DMW.OnOffKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVal(DXO10W.StyleSet openXmlElement, DMW.OnOffKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(value);
  }
  
  public static DMW.StyleSet? CreateModelElement(DXO10W.StyleSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StyleSet();
      value.Id = GetId(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.StyleSet? openXmlElement, DMW.StyleSet? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleSet value)
    where OpenXmlElementType: DXO10W.StyleSet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.StyleSet openXmlElement, DMW.StyleSet value)
  {
    SetId(openXmlElement, value?.Id);
    SetVal(openXmlElement, value?.Val);
  }
}
