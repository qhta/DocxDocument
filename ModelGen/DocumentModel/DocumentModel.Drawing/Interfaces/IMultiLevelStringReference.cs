namespace DocumentModel.Drawing;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public interface IMultiLevelStringReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public DocumentModel.Drawing.IMultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IMultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
