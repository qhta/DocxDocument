namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public static class TintEffectConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  private static Int32? GetHue(DXDraw.TintEffect openXmlElement)
  {
    return openXmlElement.Hue?.Value;
  }
  
  private static void SetHue(DXDraw.TintEffect openXmlElement, Int32? value)
  {
    openXmlElement.Hue = value;
  }
  
  /// <summary>
  /// Amount
  /// </summary>
  private static Int32? GetAmount(DXDraw.TintEffect openXmlElement)
  {
    return openXmlElement.Amount?.Value;
  }
  
  private static void SetAmount(DXDraw.TintEffect openXmlElement, Int32? value)
  {
    openXmlElement.Amount = value;
  }
  
  public static DMDraws.TintEffect? CreateModelElement(DXDraw.TintEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.TintEffect();
      value.Hue = GetHue(openXmlElement);
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TintEffect? value)
    where OpenXmlElementType: DXDraw.TintEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHue(openXmlElement, value?.Hue);
      SetAmount(openXmlElement, value?.Amount);
      return openXmlElement;
    }
    return default;
  }
}
