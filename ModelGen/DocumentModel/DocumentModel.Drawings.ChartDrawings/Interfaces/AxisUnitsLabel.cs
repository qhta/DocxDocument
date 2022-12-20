namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
public partial interface AxisUnitsLabel
{
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Text? Text { get; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
