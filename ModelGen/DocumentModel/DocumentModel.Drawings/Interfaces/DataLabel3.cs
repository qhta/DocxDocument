namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public interface DataLabel3
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DataLabelPos? Pos { get ; set; }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public NumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DataLabelVisibilities? DataLabelVisibilities { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
