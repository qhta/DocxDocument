namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public partial class LineChartExtensionImpl: ModelElementImpl, LineChartExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LineChartExtensionImpl(): base() {}
  
  public LineChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredLineSeriesExtensionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredLineSeriesExtensionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
