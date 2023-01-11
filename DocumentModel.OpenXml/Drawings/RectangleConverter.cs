namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public static class RectangleConverter
{
  /// <summary>
  /// Left
  /// </summary>
  public static String? GetLeft(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  public static void SetLeft(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Left = new StringValue { Value = value };
      else
        openXmlElement.Left = null;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  public static String? GetTop(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  public static void SetTop(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Top = new StringValue { Value = value };
      else
        openXmlElement.Top = null;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  public static String? GetRight(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  public static void SetRight(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Right = new StringValue { Value = value };
      else
        openXmlElement.Right = null;
  }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  public static String? GetBottom(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  public static void SetBottom(DocumentFormat.OpenXml.Drawing.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
