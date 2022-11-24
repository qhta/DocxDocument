namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public interface IDataLabelFieldTableEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public ITextFieldGuid? TextFieldGuid { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public IFormula? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public IDataLabelFieldTableCache? DataLabelFieldTableCache { get ; set; }
  
}
