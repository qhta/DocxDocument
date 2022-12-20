namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public partial interface ChartSpace
{
  /// <summary>
  /// ChartData.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ChartData? ChartData { get; set; }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Chart? Chart { get; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody { get; set; }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ColorMappingType? ColorMappingType { get; set; }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.FormatOverrides? FormatOverrides { get; set; }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PrintSettings? PrintSettings { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
  /// <summary>
  /// Gets the ExtendedChartPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.ExtendedChartPart? ExtendedChartPart { get; set; }
  
}
