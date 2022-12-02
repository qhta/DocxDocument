namespace DocumentModel.Drawing;

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
  public DocumentModel.Drawing.INumberingCache? NumberingCache { get ; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public DocumentModel.Drawing.INumRefExtensionList? NumRefExtensionList { get ; set; }
  
}
