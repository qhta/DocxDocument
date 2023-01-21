namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public static class RectangleConverter
{
  /// <summary>
  /// Left
  /// </summary>
  private static String? GetLeft(DXDraw.Rectangle openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  private static void SetLeft(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Left = new StringValue { Value = value };
    else
      openXmlElement.Left = null;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  private static String? GetTop(DXDraw.Rectangle openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  private static void SetTop(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Top = new StringValue { Value = value };
    else
      openXmlElement.Top = null;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  private static String? GetRight(DXDraw.Rectangle openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  private static void SetRight(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Right = new StringValue { Value = value };
    else
      openXmlElement.Right = null;
  }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  private static String? GetBottom(DXDraw.Rectangle openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  private static void SetBottom(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bottom = new StringValue { Value = value };
    else
      openXmlElement.Bottom = null;
  }
  
  public static DMDraws.Rectangle? CreateModelElement(DXDraw.Rectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Rectangle();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Rectangle? value)
    where OpenXmlElementType: DXDraw.Rectangle, new()
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
