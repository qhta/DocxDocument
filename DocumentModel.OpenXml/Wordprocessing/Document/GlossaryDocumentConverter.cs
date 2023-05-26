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
    var element = openXmlElement?.GetFirstChild<DXW.DocumentBackground>();
    if (element != null)
      return DMXW.DocumentBackgroundConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentBackground(DXW.GlossaryDocument openXmlElement, DMW.DocumentBackground? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DocumentBackgroundConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocumentBackground>(), value, diffs, objName, propName);
  }
  
  private static void SetDocumentBackground(DXW.GlossaryDocument openXmlElement, DMW.DocumentBackground? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentBackground>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocumentBackgroundConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  private static DMW.DocParts? GetDocParts(DXW.GlossaryDocument openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocParts>();
    if (element != null)
      return DMXW.DocPartsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocParts(DXW.GlossaryDocument openXmlElement, DMW.DocParts? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DocPartsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocParts>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
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
  
  public static bool CompareModelElement(DXW.GlossaryDocument? openXmlElement, DMW.GlossaryDocument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocumentBackground(openXmlElement, value.DocumentBackground, diffs, objName, propName))
        ok = false;
      if (!CmpDocParts(openXmlElement, value.DocParts, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.GlossaryDocument value)
    where OpenXmlElementType: DXW.GlossaryDocument, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.GlossaryDocument openXmlElement, DMW.GlossaryDocument value)
  {
    SetDocumentBackground(openXmlElement, value?.DocumentBackground);
    SetDocParts(openXmlElement, value?.DocParts);
  }
}
