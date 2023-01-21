namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public static class Point2DTypeConverter
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  private static Int64? GetX(DXDraw.Point2DType openXmlElement)
  {
    return openXmlElement.X?.Value;
  }
  
  private static void SetX(DXDraw.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  private static Int64? GetY(DXDraw.Point2DType openXmlElement)
  {
    return openXmlElement.Y?.Value;
  }
  
  private static void SetY(DXDraw.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  public static DMDraws.Point2DType? CreateModelElement(DXDraw.Point2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Point2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Point2DType? value)
    where OpenXmlElementType: DXDraw.Point2DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetX(openXmlElement, value?.X);
      SetY(openXmlElement, value?.Y);
      return openXmlElement;
    }
    return default;
  }
}
