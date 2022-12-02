namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public interface IStringReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public IStringCache? StringCache { get ; set; }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public IStrRefExtensionList? StrRefExtensionList { get ; set; }
  
}
