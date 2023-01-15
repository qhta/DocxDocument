using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BackgroundMark Class.
/// </summary>
public static class BackgroundMarkConverter
{
  /// <summary>
  ///   x1, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetFirstXCoordinate(BackgroundMark? openXmlElement)
  {
    return openXmlElement?.FirstXCoordinate?.Value;
  }

  public static void SetFirstXCoordinate(BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstXCoordinate = value;
  }

  /// <summary>
  ///   y1, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetFirstYCoordinate(BackgroundMark? openXmlElement)
  {
    return openXmlElement?.FirstYCoordinate?.Value;
  }

  public static void SetFirstYCoordinate(BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstYCoordinate = value;
  }

  /// <summary>
  ///   x2, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSecondXCoordinate(BackgroundMark? openXmlElement)
  {
    return openXmlElement?.SecondXCoordinate?.Value;
  }

  public static void SetSecondXCoordinate(BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SecondXCoordinate = value;
  }

  /// <summary>
  ///   y2, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSecondYCoordinate(BackgroundMark? openXmlElement)
  {
    return openXmlElement?.SecondYCoordinate?.Value;
  }

  public static void SetSecondYCoordinate(BackgroundMark? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SecondYCoordinate = value;
  }

  public static DocumentModel.Drawings.BackgroundMark? CreateModelElement(BackgroundMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundMark();
      value.FirstXCoordinate = GetFirstXCoordinate(openXmlElement);
      value.FirstYCoordinate = GetFirstYCoordinate(openXmlElement);
      value.SecondXCoordinate = GetSecondXCoordinate(openXmlElement);
      value.SecondYCoordinate = GetSecondYCoordinate(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BackgroundMark? value)
    where OpenXmlElementType : BackgroundMark, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFirstXCoordinate(openXmlElement, value?.FirstXCoordinate);
      SetFirstYCoordinate(openXmlElement, value?.FirstYCoordinate);
      SetSecondXCoordinate(openXmlElement, value?.SecondXCoordinate);
      SetSecondYCoordinate(openXmlElement, value?.SecondYCoordinate);
      return openXmlElement;
    }
    return default;
  }
}