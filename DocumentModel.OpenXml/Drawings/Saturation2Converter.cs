using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the Saturation Class.
/// </summary>
public static class Saturation2Converter
{
  /// <summary>
  ///   sat, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSaturationAmount(Saturation? openXmlElement)
  {
    return openXmlElement?.SaturationAmount?.Value;
  }

  public static void SetSaturationAmount(Saturation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SaturationAmount = value;
  }

  public static Saturation2? CreateModelElement(Saturation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Saturation2();
      value.SaturationAmount = GetSaturationAmount(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Saturation2? value)
    where OpenXmlElementType : Saturation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSaturationAmount(openXmlElement, value?.SaturationAmount);
      return openXmlElement;
    }
    return default;
  }
}