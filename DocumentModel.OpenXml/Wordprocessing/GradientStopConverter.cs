using DocumentFormat.OpenXml.Office2010.Word;
using RgbColorModelHex = DocumentModel.Wordprocessing.RgbColorModelHex;
using SchemeColor = DocumentModel.Wordprocessing.SchemeColor;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the GradientStop Class.
/// </summary>
public static class GradientStopConverter
{
  /// <summary>
  ///   pos, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetStopPosition(GradientStop? openXmlElement)
  {
    return openXmlElement?.StopPosition?.Value;
  }

  public static void SetStopPosition(GradientStop? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StopPosition = value;
  }

  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public static RgbColorModelHex? GetRgbColorModelHex(GradientStop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelHex(GradientStop? openXmlElement, RgbColorModelHex? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public static SchemeColor? GetSchemeColor(GradientStop? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemeColor(GradientStop? openXmlElement, SchemeColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.GradientStop? CreateModelElement(GradientStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GradientStop();
      value.StopPosition = GetStopPosition(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GradientStop? value)
    where OpenXmlElementType : GradientStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStopPosition(openXmlElement, value?.StopPosition);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}