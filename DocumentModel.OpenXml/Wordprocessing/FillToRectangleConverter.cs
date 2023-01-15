using DocumentFormat.OpenXml.Office2010.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FillToRectangle Class.
/// </summary>
public static class FillToRectangleConverter
{
  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLeft(FillToRectangle? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }

  public static void SetLeft(FillToRectangle? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Left = value;
  }

  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTop(FillToRectangle? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }

  public static void SetTop(FillToRectangle? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Top = value;
  }

  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetRight(FillToRectangle? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }

  public static void SetRight(FillToRectangle? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Right = value;
  }

  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBottom(FillToRectangle? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }

  public static void SetBottom(FillToRectangle? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bottom = value;
  }

  public static DocumentModel.Wordprocessing.FillToRectangle? CreateModelElement(FillToRectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FillToRectangle();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FillToRectangle? value)
    where OpenXmlElementType : FillToRectangle, new()
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