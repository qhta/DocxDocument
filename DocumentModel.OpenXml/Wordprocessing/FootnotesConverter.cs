namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public static class FootnotesConverter
{
  private static DMW.Footnote? GetFootnote(DXW.Footnotes openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Footnote>();
    if (element != null)
      return DMXW.FootnoteConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFootnote(DXW.Footnotes openXmlElement, DMW.Footnote? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Footnote>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Wordprocessing.Footnotes? CreateModelElement(DXW.Footnotes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Footnotes();
      value.Footnote = GetFootnote(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Footnotes? openXmlElement, DMW.Footnotes? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFootnote(openXmlElement, value.Footnote, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Footnotes value)
    where OpenXmlElementType: DXW.Footnotes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Footnotes openXmlElement, DMW.Footnotes value)
  {
    SetFootnote(openXmlElement, value?.Footnote);
  }
}
