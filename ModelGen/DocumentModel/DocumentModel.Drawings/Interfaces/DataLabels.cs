namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public interface DataLabels // : DocumentModel.BaseTypes.ModelElement
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
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DataLabelVisibilities? DataLabelVisibilities { get ; set; }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public String? SeparatorXsdstring { get ; set; }
  
  public Collection<DataLabel>? DataLabels { get ; set; }
  
  public Collection<DataLabelHidden>? DataLabelHiddens { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
