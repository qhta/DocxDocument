namespace DocumentModel.Drawings;

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
