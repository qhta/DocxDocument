namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public static class PositiveSize2DTypeConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public static Int64? GetCx(DocumentFormat.OpenXml.Drawing.PositiveSize2DType? openXmlElement)
  {
    return openXmlElement?.Cx?.Value;
  }
  
  public static void SetCx(DocumentFormat.OpenXml.Drawing.PositiveSize2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public static Int64? GetCy(DocumentFormat.OpenXml.Drawing.PositiveSize2DType? openXmlElement)
  {
    return openXmlElement?.Cy?.Value;
  }
  
  public static void SetCy(DocumentFormat.OpenXml.Drawing.PositiveSize2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Cy = value;
  }
  
  public static DocumentModel.Drawings.PositiveSize2DType? CreateModelElement(DocumentFormat.OpenXml.Drawing.PositiveSize2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PositiveSize2DType();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PositiveSize2DType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PositiveSize2DType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
