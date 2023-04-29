namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public static class EndnotesConverter
{
  private static DMW.Endnote? GetEndnote(DXW.Endnotes openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Endnote>();
    if (element != null)
      return DMXW.EndnoteConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndnote(DXW.Endnotes openXmlElement, DMW.Endnote? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnoteConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Endnote>(), value, diffs, objName);
  }
  
  private static void SetEndnote(DXW.Endnotes openXmlElement, DMW.Endnote? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Endnote>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EndnoteConverter.CreateOpenXmlElement(value);
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
  
  public static bool CompareModelElement(DXW.Endnotes? openXmlElement, DMW.Endnotes? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEndnote(openXmlElement, value.Endnote, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Endnotes value)
    where OpenXmlElementType: DXW.Endnotes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Endnotes openXmlElement, DMW.Endnotes value)
  {
    SetEndnote(openXmlElement, value?.Endnote);
  }
}
