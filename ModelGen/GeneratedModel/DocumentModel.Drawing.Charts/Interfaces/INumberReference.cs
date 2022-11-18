namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Number Reference.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberingCache))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumRefExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFormula))]
public interface INumberReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Drawing.Charts.IFormula? Formula { get ; set; }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public INumberingCache? NumberingCache { get ; set; }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public INumRefExtensionList? NumRefExtensionList { get ; set; }
  
}
