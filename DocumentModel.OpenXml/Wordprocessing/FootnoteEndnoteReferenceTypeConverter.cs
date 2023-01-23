namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public static class FootnoteEndnoteReferenceTypeConverter
{
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  private static Boolean? GetCustomMarkFollows(DXW.FootnoteEndnoteReferenceType openXmlElement)
  {
    return openXmlElement?.CustomMarkFollows?.Value;
  }
  
  private static bool CmpCustomMarkFollows(DXW.FootnoteEndnoteReferenceType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CustomMarkFollows?.Value == value;
  }
  
  private static void SetCustomMarkFollows(DXW.FootnoteEndnoteReferenceType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CustomMarkFollows = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CustomMarkFollows = null;
  }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  private static Int64? GetId(DXW.FootnoteEndnoteReferenceType openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static bool CmpId(DXW.FootnoteEndnoteReferenceType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Id?.Value == value;
  }
  
  private static void SetId(DXW.FootnoteEndnoteReferenceType openXmlElement, Int64? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DMW.FootnoteEndnoteReferenceType? CreateModelElement(DXW.FootnoteEndnoteReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FootnoteEndnoteReferenceType();
      value.CustomMarkFollows = GetCustomMarkFollows(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FootnoteEndnoteReferenceType? openXmlElement, DMW.FootnoteEndnoteReferenceType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomMarkFollows(openXmlElement, value.CustomMarkFollows, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FootnoteEndnoteReferenceType? value)
    where OpenXmlElementType: DXW.FootnoteEndnoteReferenceType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomMarkFollows(openXmlElement, value?.CustomMarkFollows);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
