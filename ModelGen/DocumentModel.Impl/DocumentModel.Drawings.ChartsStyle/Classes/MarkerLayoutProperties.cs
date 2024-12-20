namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public partial class MarkerLayoutPropertiesImpl: ModelElementImpl, MarkerLayoutProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MarkerLayoutPropertiesImpl(): base() {}
  
  public MarkerLayoutPropertiesImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.MarkerStyle? Symbol
  {
    get => (DocumentModel.Drawings.ChartsStyle.MarkerStyle?)OpenXmlElement?.Symbol?.Value;
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
    get => (System.Byte?)OpenXmlElement?.Size?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = (System.Byte?)value;
    }
  }
  
}
