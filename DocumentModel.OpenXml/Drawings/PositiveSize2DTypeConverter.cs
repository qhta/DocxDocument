namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public static class PositiveSize2DTypeConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DocumentFormat.OpenXml.Drawing.PositiveSize2DType openXmlElement)
  {
    return openXmlElement.Cx?.Value;
  }
  
  private static void SetCx(DocumentFormat.OpenXml.Drawing.PositiveSize2DType openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DocumentFormat.OpenXml.Drawing.PositiveSize2DType openXmlElement)
  {
    return openXmlElement.Cy?.Value;
  }
  
  private static void SetCy(DocumentFormat.OpenXml.Drawing.PositiveSize2DType openXmlElement, Int64? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCx(openXmlElement, value?.Cx);
      SetCy(openXmlElement, value?.Cy);
      return openXmlElement;
    }
    return default;
  }
}
