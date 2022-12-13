namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public interface DataLabel
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get ; set; }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.DataLabelPos? Pos { get ; set; }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public DocumentModel.Drawings16.Charts.NumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Drawings16.Charts.DataLabelVisibilities? DataLabelVisibilities { get ; set; }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public String? SeparatorXsdstring { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
