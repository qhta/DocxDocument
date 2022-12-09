namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public class MarkerLayoutPropertiesImpl: ModelElementImpl, MarkerLayoutProperties
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// size, this property is only available in Office 2013 and later.
  /// </summary>
  public Byte? Size
  {
    get => (Byte?)OpenXmlElement?.Size?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = (System.Byte?)value;
    }
  }
  
}
