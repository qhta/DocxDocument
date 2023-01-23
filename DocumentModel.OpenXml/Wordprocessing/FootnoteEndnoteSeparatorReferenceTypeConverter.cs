namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public static class FootnoteEndnoteSeparatorReferenceTypeConverter
{
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  private static Int64? GetId(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static bool CmpId(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Id?.Value == value;
  }
  
  private static void SetId(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement, Int64? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DMW.FootnoteEndnoteSeparatorReferenceType? CreateModelElement(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FootnoteEndnoteSeparatorReferenceType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement, DMW.FootnoteEndnoteSeparatorReferenceType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FootnoteEndnoteSeparatorReferenceType? value)
    where OpenXmlElementType: DXW.FootnoteEndnoteSeparatorReferenceType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
