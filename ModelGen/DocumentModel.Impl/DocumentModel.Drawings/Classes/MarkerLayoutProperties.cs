namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public class MarkerLayoutPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>, MarkerLayoutProperties
{
  /// <summary>
  /// symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public MarkerStyle? Symbol
  {
    get => (MarkerStyle?)OpenXmlElement?.Symbol?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Symbol = (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle?)value;
    }
  }
  
}
