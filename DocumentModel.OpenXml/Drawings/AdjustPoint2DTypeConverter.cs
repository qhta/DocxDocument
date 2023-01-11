namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AdjustPoint2DType Class.
/// </summary>
public static class AdjustPoint2DTypeConverter
{
  /// <summary>
  /// X-Coordinate
  /// </summary>
  public static String? GetX(DocumentFormat.OpenXml.Drawing.AdjustPoint2DType? openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  public static void SetX(DocumentFormat.OpenXml.Drawing.AdjustPoint2DType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.X = new StringValue { Value = value };
      else
        openXmlElement.X = null;
  }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  public static String? GetY(DocumentFormat.OpenXml.Drawing.AdjustPoint2DType? openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  public static void SetY(DocumentFormat.OpenXml.Drawing.AdjustPoint2DType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Y = new StringValue { Value = value };
      else
        openXmlElement.Y = null;
  }
  
  public static DocumentModel.Drawings.AdjustPoint2DType? CreateModelElement(DocumentFormat.OpenXml.Drawing.AdjustPoint2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustPoint2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustPoint2DType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AdjustPoint2DType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
