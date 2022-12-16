namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public class PieChartExtensionImpl: ModelElementImpl, PieChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PieChartExtensionImpl(): base() {}
  
  public PieChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.Charts.FilteredPieSeries? FilteredPieSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredPieSeriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredPieSeriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
