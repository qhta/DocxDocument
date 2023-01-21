namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public static class FootnotesConverter
{
  private static DMW.Footnote? GetFootnote(DXW.Footnotes openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Footnote>();
    if (itemElement != null)
      return DMXW.FootnoteConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFootnote(DXW.Footnotes openXmlElement, DMW.Footnote? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Footnote>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FootnoteConverter.CreateOpenXmlElement<DXW.Footnote>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Footnotes? CreateModelElement(DXW.Footnotes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Footnotes();
      value.Footnote = GetFootnote(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Footnotes? value)
    where OpenXmlElementType: DXW.Footnotes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFootnote(openXmlElement, value?.Footnote);
      return openXmlElement;
    }
    return default;
  }
}
