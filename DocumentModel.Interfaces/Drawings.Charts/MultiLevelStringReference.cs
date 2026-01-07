namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Multi Level String Reference.
/// </summary>
public interface MultiLevelStringReference
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public string? Formula { get; set; }
  /// <summary>
  ///   MultiLevelStringCache.
  /// </summary>
  public MultiLevelStringCache? MultiLevelStringCache { get; set; }
  /// <summary>
  ///   MultiLvlStrRefExtensionList.
  /// </summary>
  public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get; set; }
}