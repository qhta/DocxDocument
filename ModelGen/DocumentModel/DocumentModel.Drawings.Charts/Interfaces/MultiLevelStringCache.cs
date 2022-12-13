namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public interface MultiLevelStringCache
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public UInt32? PointCount { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.Level>? Levels { get ; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
