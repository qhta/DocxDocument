namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the RelativeRectangleType Class.
/// </summary>
public static class RelativeRectangleTypeConverter
{
  /// <summary>
  /// Left Offset
  /// </summary>
  private static Int32? GetLeft(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Left?.Value;
  }
  
  private static void SetLeft(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  private static Int32? GetTop(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Top?.Value;
  }
  
  private static void SetTop(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  private static Int32? GetRight(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Right?.Value;
  }
  
  private static void SetRight(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  private static Int32? GetBottom(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement)
  {
    return openXmlElement.Bottom?.Value;
  }
  
  private static void SetBottom(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  public static DocumentModel.Drawings.RelativeRectangleType? CreateModelElement(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RelativeRectangleType();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.RelativeRectangleType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.RelativeRectangleType, new()
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
