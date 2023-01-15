using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the AlphaModulationFixed Class.
/// </summary>
public static class AlphaModulationFixedConverter
{
  /// <summary>
  ///   Amount
  /// </summary>
  public static Int32? GetAmount(AlphaModulationFixed? openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }

  public static void SetAmount(AlphaModulationFixed? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Amount = value;
  }

  public static DocumentModel.Drawings.AlphaModulationFixed? CreateModelElement(AlphaModulationFixed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaModulationFixed();
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AlphaModulationFixed? value)
    where OpenXmlElementType : AlphaModulationFixed, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAmount(openXmlElement, value?.Amount);
      return openXmlElement;
    }
    return default;
  }
}