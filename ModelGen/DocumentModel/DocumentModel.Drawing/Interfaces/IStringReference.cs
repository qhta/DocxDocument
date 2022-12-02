namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public interface IStringReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public DocumentModel.Drawing.IStringCache? StringCache { get ; set; }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IStrRefExtensionList? StrRefExtensionList { get ; set; }
  
}
