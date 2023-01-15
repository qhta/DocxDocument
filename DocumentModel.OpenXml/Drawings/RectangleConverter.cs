using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Shape Text Rectangle.
/// </summary>
public static class RectangleConverter
{
  /// <summary>
  ///   Left
  /// </summary>
  public static String? GetLeft(Rectangle? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }

  public static void SetLeft(Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Left = new StringValue { Value = value };
      else
        openXmlElement.Left = null;
  }

  /// <summary>
  ///   Top
  /// </summary>
  public static String? GetTop(Rectangle? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }

  public static void SetTop(Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Top = new StringValue { Value = value };
      else
        openXmlElement.Top = null;
  }

  /// <summary>
  ///   Right
  /// </summary>
  public static String? GetRight(Rectangle? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }

  public static void SetRight(Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Right = new StringValue { Value = value };
      else
        openXmlElement.Right = null;
  }

  /// <summary>
  ///   Bottom Position
  /// </summary>
  public static String? GetBottom(Rectangle? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }

  public static void SetBottom(Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bottom = new StringValue { Value = value };
      else
        openXmlElement.Bottom = null;
  }

  public static DocumentModel.Drawings.Rectangle? CreateModelElement(Rectangle? openXmlElement)
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
    where OpenXmlElementType : Rectangle, new()
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