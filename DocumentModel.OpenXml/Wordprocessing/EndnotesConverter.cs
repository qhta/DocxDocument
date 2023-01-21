namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public static class EndnotesConverter
{
  private static DMW.Endnote? GetEndnote(DXW.Endnotes openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Endnote>();
    if (itemElement != null)
      return DMXW.EndnoteConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndnote(DXW.Endnotes openXmlElement, DMW.Endnote? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Endnote>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EndnoteConverter.CreateOpenXmlElement<DXW.Endnote>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Endnotes? CreateModelElement(DXW.Endnotes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Endnotes();
      value.Endnote = GetEndnote(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Endnotes? value)
    where OpenXmlElementType: DXW.Endnotes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEndnote(openXmlElement, value?.Endnote);
      return openXmlElement;
    }
    return default;
  }
}
