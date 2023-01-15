using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the RelativeRectangleType Class.
/// </summary>
public static class RelativeRectangleTypeConverter
{
  /// <summary>
  ///   Left Offset
  /// </summary>
  public static Int32? GetLeft(RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }

  public static void SetLeft(RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Left = value;
  }

  /// <summary>
  ///   Top Offset
  /// </summary>
  public static Int32? GetTop(RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }

  public static void SetTop(RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Top = value;
  }

  /// <summary>
  ///   Right Offset
  /// </summary>
  public static Int32? GetRight(RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }

  public static void SetRight(RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Right = value;
  }

  /// <summary>
  ///   Bottom Offset
  /// </summary>
  public static Int32? GetBottom(RelativeRectangleType? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }

  public static void SetBottom(RelativeRectangleType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bottom = value;
  }

  public static DocumentModel.Drawings.RelativeRectangleType? CreateModelElement(RelativeRectangleType? openXmlElement)
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
    where OpenXmlElementType : RelativeRectangleType, new()
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