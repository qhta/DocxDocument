namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public static class Point2DTypeConverter
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public static Int64? GetX(DocumentFormat.OpenXml.Drawing.Point2DType? openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  public static void SetX(DocumentFormat.OpenXml.Drawing.Point2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public static Int64? GetY(DocumentFormat.OpenXml.Drawing.Point2DType? openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  public static void SetY(DocumentFormat.OpenXml.Drawing.Point2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Y = value;
  }
  
  public static DocumentModel.Drawings.Point2DType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Point2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Point2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Point2DType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Point2DType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
