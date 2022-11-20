namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringCache))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStrRefExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFormula))]
public interface IStringReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Drawing.Charts.IFormula? Formula { get ; set; }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public IStringCache? StringCache { get ; set; }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public IStrRefExtensionList? StrRefExtensionList { get ; set; }
  
}
