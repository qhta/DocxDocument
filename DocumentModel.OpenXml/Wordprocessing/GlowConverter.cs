using DocumentFormat.OpenXml.Office2010.Word;
using RgbColorModelHex = DocumentModel.Wordprocessing.RgbColorModelHex;
using SchemeColor = DocumentModel.Wordprocessing.SchemeColor;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Glow Class.
/// </summary>
public static class GlowConverter
{
  /// <summary>
  ///   rad, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetGlowRadius(Glow? openXmlElement)
  {
    return openXmlElement?.GlowRadius?.Value;
  }

  public static void SetGlowRadius(Glow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.GlowRadius = value;
  }

  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public static RgbColorModelHex? GetRgbColorModelHex(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelHex(Glow? openXmlElement, RgbColorModelHex? value)
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
  public static SchemeColor? GetSchemeColor(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemeColor(Glow? openXmlElement, SchemeColor? value)
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

  public static DocumentModel.Wordprocessing.Glow? CreateModelElement(Glow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Glow();
      value.GlowRadius = GetGlowRadius(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Glow? value)
    where OpenXmlElementType : Glow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGlowRadius(openXmlElement, value?.GlowRadius);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}