namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public static class GlossaryDocumentConverter
{
  /// <summary>
  /// Document Background.
  /// </summary>
  private static DMW.DocumentBackground? GetDocumentBackground(DXW.GlossaryDocument openXmlElement)
  {
    return DMXW.DocumentBackgroundConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DocumentBackground>());
  }
  
  private static bool CmpDocumentBackground(DXW.GlossaryDocument openXmlElement, DMW.DocumentBackground? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocumentBackgroundConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.DocumentBackground>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocumentBackground(DXW.GlossaryDocument openXmlElement, DMW.DocumentBackground? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentBackground>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocumentBackgroundConverter.CreateOpenXmlElement<DXW.DocumentBackground>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  private static DMW.DocParts? GetDocParts(DXW.GlossaryDocument openXmlElement)
  {
    return DMXW.DocPartsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DocParts>());
  }
  
  private static bool CmpDocParts(DXW.GlossaryDocument openXmlElement, DMW.DocParts? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocPartsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.DocParts>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocParts(DXW.GlossaryDocument openXmlElement, DMW.DocParts? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocParts>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocPartsConverter.CreateOpenXmlElement<DXW.DocParts>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.GlossaryDocument? CreateModelElement(DXW.GlossaryDocument? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.GlossaryDocument();
      value.DocumentBackground = GetDocumentBackground(openXmlElement);
      value.DocParts = GetDocParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.GlossaryDocument? openXmlElement, DMW.GlossaryDocument? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocumentBackground(openXmlElement, value.DocumentBackground, diffs, objName))
        ok = false;
      if (!CmpDocParts(openXmlElement, value.DocParts, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.GlossaryDocument? value)
    where OpenXmlElementType: DXW.GlossaryDocument, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocumentBackground(openXmlElement, value?.DocumentBackground);
      SetDocParts(openXmlElement, value?.DocParts);
      return openXmlElement;
    }
    return default;
  }
}
