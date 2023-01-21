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
