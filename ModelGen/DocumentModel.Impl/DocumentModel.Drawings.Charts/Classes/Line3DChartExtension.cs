namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public partial class Line3DChartExtensionImpl: ModelElementImpl, Line3DChartExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Line3DChartExtensionImpl(): base() {}
  
  public Line3DChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension openXmlElement): base(openXmlElement)
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
