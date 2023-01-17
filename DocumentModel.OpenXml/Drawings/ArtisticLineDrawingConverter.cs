namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public static class ArtisticLineDrawingConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetPencilSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement.PencilSize?.Value;
  }
  
  private static void SetPencilSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.PencilSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticLineDrawing? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticLineDrawing();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.PencilSize = GetPencilSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticLineDrawing? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetPencilSize(openXmlElement, value?.PencilSize);
      return openXmlElement;
    }
    return default;
  }
}
