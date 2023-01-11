namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPencilGrayscale Class.
/// </summary>
public static class ArtisticPencilGrayscaleConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBrushSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? openXmlElement)
  {
    return openXmlElement?.BrushSize?.Value;
  }
  
  public static void SetBrushSize(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BrushSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPencilGrayscale? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPencilGrayscale();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPencilGrayscale? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
