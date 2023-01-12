namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the RelativeRectangleType Class.
/// </summary>
public static class RelativeRectangleTypeConverter
{
  /// <summary>
  /// Left Offset
  /// </summary>
  public static Int32? GetLeft(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  public static void SetLeft(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  public static Int32? GetTop(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  public static void SetTop(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  public static Int32? GetRight(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  public static void SetRight(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  public static Int32? GetBottom(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  public static void SetBottom(DocumentFormat.OpenXml.Drawing.RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
