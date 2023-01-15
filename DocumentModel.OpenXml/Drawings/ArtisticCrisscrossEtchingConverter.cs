using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticCrisscrossEtching Class.
/// </summary>
public static class ArtisticCrisscrossEtchingConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticCrisscrossEtching? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticCrisscrossEtching? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetPressure(ArtisticCrisscrossEtching? openXmlElement)
  {
    return openXmlElement?.Pressure?.Value;
  }

  public static void SetPressure(ArtisticCrisscrossEtching? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pressure = value;
  }

  public static DocumentModel.Drawings.ArtisticCrisscrossEtching? CreateModelElement(ArtisticCrisscrossEtching? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticCrisscrossEtching();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Pressure = GetPressure(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticCrisscrossEtching? value)
    where OpenXmlElementType : ArtisticCrisscrossEtching, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetPressure(openXmlElement, value?.Pressure);
      return openXmlElement;
    }
    return default;
  }
}