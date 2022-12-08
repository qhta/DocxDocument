namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public class Pie3DChartExtensionImpl: ModelElementImpl, Pie3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension?)_OpenXmlElement;
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
  
  public FilteredPieSeries? FilteredPieSeries
  {
    get;
    set;
  }
  
}
