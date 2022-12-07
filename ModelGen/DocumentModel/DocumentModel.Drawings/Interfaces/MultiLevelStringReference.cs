namespace DocumentModel.Drawings;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public interface MultiLevelStringReference
{
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public MultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
