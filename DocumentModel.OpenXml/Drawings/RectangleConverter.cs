namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public static class RectangleConverter
{
  /// <summary>
  /// Left
  /// </summary>
  private static String? GetLeft(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  private static void SetLeft(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Left = new StringValue { Value = value };
    else
      openXmlElement.Left = null;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  private static String? GetTop(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  private static void SetTop(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Top = new StringValue { Value = value };
    else
      openXmlElement.Top = null;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  private static String? GetRight(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  private static void SetRight(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Right = new StringValue { Value = value };
    else
      openXmlElement.Right = null;
  }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  private static String? GetBottom(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  private static void SetBottom(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bottom = new StringValue { Value = value };
    else
      openXmlElement.Bottom = null;
  }
  
  public static DocumentModel.Drawings.Rectangle? CreateModelElement(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Rectangle();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Rectangle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Rectangle, new()
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
