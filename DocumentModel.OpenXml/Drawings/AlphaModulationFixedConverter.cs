namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaModulationFixed Class.
/// </summary>
public static class AlphaModulationFixedConverter
{
  /// <summary>
  /// Amount
  /// </summary>
  private static Int32? GetAmount(DXDraw.AlphaModulationFixed openXmlElement)
  {
    return openXmlElement.Amount?.Value;
  }
  
  private static void SetAmount(DXDraw.AlphaModulationFixed openXmlElement, Int32? value)
  {
    openXmlElement.Amount = value;
  }
  
  public static DMDraws.AlphaModulationFixed? CreateModelElement(DXDraw.AlphaModulationFixed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AlphaModulationFixed();
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaModulationFixed? value)
    where OpenXmlElementType: DXDraw.AlphaModulationFixed, new()
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
