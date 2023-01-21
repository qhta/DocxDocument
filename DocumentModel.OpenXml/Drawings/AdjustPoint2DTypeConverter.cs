namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AdjustPoint2DType Class.
/// </summary>
public static class AdjustPoint2DTypeConverter
{
  /// <summary>
  /// X-Coordinate
  /// </summary>
  private static String? GetX(DXDraw.AdjustPoint2DType openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  private static void SetX(DXDraw.AdjustPoint2DType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.X = new StringValue { Value = value };
    else
      openXmlElement.X = null;
  }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  private static String? GetY(DXDraw.AdjustPoint2DType openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  private static void SetY(DXDraw.AdjustPoint2DType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Y = new StringValue { Value = value };
    else
      openXmlElement.Y = null;
  }
  
  public static DMDraws.AdjustPoint2DType? CreateModelElement(DXDraw.AdjustPoint2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AdjustPoint2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustPoint2DType? value)
    where OpenXmlElementType: DXDraw.AdjustPoint2DType, new()
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
