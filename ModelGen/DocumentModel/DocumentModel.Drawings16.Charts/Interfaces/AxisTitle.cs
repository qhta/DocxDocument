namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the AxisTitle Class.
/// </summary>
public interface AxisTitle
{
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Drawings16.Charts.Text? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
