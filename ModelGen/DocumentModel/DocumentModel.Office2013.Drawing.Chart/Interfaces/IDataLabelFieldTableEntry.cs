namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public interface IDataLabelFieldTableEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public System.String? TextFieldGuid { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IDataLabelFieldTableCache? DataLabelFieldTableCache { get ; set; }
  
}
