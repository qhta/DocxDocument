namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public interface IStringReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Formula { get ; set; }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public DocumentModel.Drawing.Charts.IStringDataType? StringCache { get ; set; }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? StrRefExtensionList { get ; set; }
  
}
