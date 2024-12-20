namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public partial class BarChartExtensionImpl: ModelElementImpl, BarChartExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BarChartExtensionImpl(): base() {}
  
  public BarChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.FilteredBarSeries? FilteredBarSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredBarSeriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredBarSeriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
