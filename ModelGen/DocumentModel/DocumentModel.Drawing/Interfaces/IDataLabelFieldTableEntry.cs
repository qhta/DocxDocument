namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public interface IDataLabelFieldTableEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public String? TextFieldGuid { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public IDataLabelFieldTableCache? DataLabelFieldTableCache { get ; set; }
  
}
