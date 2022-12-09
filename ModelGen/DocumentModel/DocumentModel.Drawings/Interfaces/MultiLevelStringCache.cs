namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public interface MultiLevelStringCache
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public UInt32? PointCount { get ; set; }
  
  public Collection<Level>? Levels { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
