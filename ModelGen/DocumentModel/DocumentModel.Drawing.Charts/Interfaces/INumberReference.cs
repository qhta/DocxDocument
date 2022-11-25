namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public interface INumberReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Formula { get ; set; }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberDataType? NumberingCache { get ; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? NumRefExtensionList { get ; set; }
  
}
