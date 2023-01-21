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
