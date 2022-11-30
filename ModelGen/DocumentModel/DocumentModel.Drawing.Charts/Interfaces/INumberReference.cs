namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public interface INumberReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberingCache? NumberingCache { get ; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumRefExtensionList? NumRefExtensionList { get ; set; }
  
}
