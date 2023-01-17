namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public static class GraphicConverter
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  private static DocumentModel.Drawings.GraphicData? GetGraphicData(DocumentFormat.OpenXml.Drawing.Graphic openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GraphicDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphicData(DocumentFormat.OpenXml.Drawing.Graphic openXmlElement, DocumentModel.Drawings.GraphicData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.GraphicDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GraphicData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Graphic? CreateModelElement(DocumentFormat.OpenXml.Drawing.Graphic? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Graphic();
      value.GraphicData = GetGraphicData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Graphic? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Graphic, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGraphicData(openXmlElement, value?.GraphicData);
      return openXmlElement;
    }
    return default;
  }
}
