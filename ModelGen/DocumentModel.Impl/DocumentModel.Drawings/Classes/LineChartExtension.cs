namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public class LineChartExtensionImpl: ModelElementImpl, LineChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension?)_OpenXmlElement;
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
  
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get;
    set;
  }
  
}
