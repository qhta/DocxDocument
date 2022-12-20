namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public partial class Surface3DChartExtensionImpl: ModelElementImpl, Surface3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Surface3DChartExtensionImpl(): base() {}
  
  public Surface3DChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.Charts.FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredSurfaceSeriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredSurfaceSeriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
