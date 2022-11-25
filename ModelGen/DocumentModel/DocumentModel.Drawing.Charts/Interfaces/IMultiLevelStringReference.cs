namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public interface IMultiLevelStringReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Formula { get ; set; }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? MultiLvlStrRefExtensionList { get ; set; }
  
}
