namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public interface MultiLevelStringReference
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.MultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
