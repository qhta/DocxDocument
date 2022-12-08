namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public class AreaChartExtensionImpl: ModelElementImpl, AreaChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public FilteredAreaSeries? FilteredAreaSeries
  {
    get;
    set;
  }
  
}
