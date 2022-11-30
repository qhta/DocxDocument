namespace DocumentModel.Drawing.Charts;

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
  public DocumentModel.Drawing.Charts.IMultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
