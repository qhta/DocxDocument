namespace DocumentModel.Drawings;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public interface MultiLevelStringReference // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public MultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
