namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public class Line3DChartExtensionImpl: ModelElementImpl, Line3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension?)_OpenXmlElement;
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
