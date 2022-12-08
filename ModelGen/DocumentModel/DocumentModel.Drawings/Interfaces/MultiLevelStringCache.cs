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
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
