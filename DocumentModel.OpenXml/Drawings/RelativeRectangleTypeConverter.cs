namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the RelativeRectangleType Class.
/// </summary>
public static class RelativeRectangleTypeConverter
{
  /// <summary>
  /// Left Offset
  /// </summary>
  private static Int32? GetLeft(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Left?.Value;
  }
  
  private static void SetLeft(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  private static Int32? GetTop(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Top?.Value;
  }
  
  private static void SetTop(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  private static Int32? GetRight(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Right?.Value;
  }
  
  private static void SetRight(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  private static Int32? GetBottom(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Bottom?.Value;
  }
  
  private static void SetBottom(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  public static DMDraws.RelativeRectangleType? CreateModelElement(DXDraw.RelativeRectangleType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.RelativeRectangleType();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.RelativeRectangleType? value)
    where OpenXmlElementType: DXDraw.RelativeRectangleType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeft(openXmlElement, value?.Left);
      SetTop(openXmlElement, value?.Top);
      SetRight(openXmlElement, value?.Right);
      SetBottom(openXmlElement, value?.Bottom);
      return openXmlElement;
    }
    return default;
  }
}
