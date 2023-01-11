namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaModulationFixed Class.
/// </summary>
public static class AlphaModulationFixedConverter
{
  /// <summary>
  /// Amount
  /// </summary>
  public static Int32? GetAmount(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed? openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }
  
  public static void SetAmount(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
