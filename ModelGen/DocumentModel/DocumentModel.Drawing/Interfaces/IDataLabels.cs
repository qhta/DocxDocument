namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public interface IDataLabels // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DataLabelPos? Pos { get ; set; }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public INumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public IDataLabelVisibilities? DataLabelVisibilities { get ; set; }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public String? SeparatorXsdstring { get ; set; }
  
  public Collection<IDataLabel>? DataLabels { get ; set; }
  
  public Collection<IDataLabelHidden>? DataLabelHiddens { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
