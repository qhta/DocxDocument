namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Style List.
/// </summary>
public static class LineStyleListConverter
{
  private static DocumentModel.Drawings.Outline? GetOutline(DocumentFormat.OpenXml.Drawing.LineStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OutlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOutline(DocumentFormat.OpenXml.Drawing.LineStyleList openXmlElement, DocumentModel.Drawings.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OutlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LineStyleList? CreateModelElement(DocumentFormat.OpenXml.Drawing.LineStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineStyleList();
      value.Outline = GetOutline(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineStyleList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LineStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOutline(openXmlElement, value?.Outline);
      return openXmlElement;
    }
    return default;
  }
}
