namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public static class FootnoteEndnoteTypeConverter
{
  /// <summary>
  /// Footnote/Endnote Type
  /// </summary>
  private static DMW.FootnoteEndnoteKind? GetType(DXW.FootnoteEndnoteType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteValues, DMW.FootnoteEndnoteKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.FootnoteEndnoteType openXmlElement, DMW.FootnoteEndnoteKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteValues, DMW.FootnoteEndnoteKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.FootnoteEndnoteType openXmlElement, DMW.FootnoteEndnoteKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteValues, DMW.FootnoteEndnoteKind>(value);
  }
  
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  private static Int64? GetId(DXW.FootnoteEndnoteType openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static bool CmpId(DXW.FootnoteEndnoteType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Id?.Value == value;
  }
  
  private static void SetId(DXW.FootnoteEndnoteType openXmlElement, Int64? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DMW.FootnoteEndnoteType? CreateModelElement(DXW.FootnoteEndnoteType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FootnoteEndnoteType();
      value.Type = GetType(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FootnoteEndnoteType? openXmlElement, DMW.FootnoteEndnoteType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FootnoteEndnoteType? value)
    where OpenXmlElementType: DXW.FootnoteEndnoteType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
