namespace DocumentModel.Drawing;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public interface IMultiLevelStringReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public IMultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public IMultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
