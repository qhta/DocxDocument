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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocumentBackground>();
    if (itemElement != null)
      return DMXW.DocumentBackgroundConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocParts>();
    if (itemElement != null)
      return DMXW.DocPartsConverter.CreateModelElement(itemElement);
    return null;
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
