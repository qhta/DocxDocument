namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaModulationFixed Class.
/// </summary>
public static class AlphaModulationFixedConverter
{
  /// <summary>
  /// Amount
  /// </summary>
  private static Int32? GetAmount(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed openXmlElement)
  {
    return openXmlElement.Amount?.Value;
  }
  
  private static void SetAmount(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed openXmlElement, Int32? value)
  {
    openXmlElement.Amount = value;
  }
  
  public static DocumentModel.Drawings.AlphaModulationFixed? CreateModelElement(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AlphaModulationFixed, new()
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
