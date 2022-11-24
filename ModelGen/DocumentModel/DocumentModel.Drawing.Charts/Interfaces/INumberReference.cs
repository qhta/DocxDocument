namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public interface INumberReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public IFormula? Formula { get ; set; }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public INumberingCache? NumberingCache { get ; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public INumRefExtensionList? NumRefExtensionList { get ; set; }
  
}
