namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public interface ChartSpace
{
  /// <summary>
  /// ChartData.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ChartData? ChartData { get ; set; }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public DocumentModel.Drawings16.Charts.Chart? Chart { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ColorMappingType.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ColorMappingType? ColorMappingType { get ; set; }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public DocumentModel.Drawings16.Charts.FormatOverrides? FormatOverrides { get ; set; }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PrintSettings? PrintSettings { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
