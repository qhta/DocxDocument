namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public interface IMultiLevelStringReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public IFormula? Formula { get ; set; }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public IMultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public IMultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
