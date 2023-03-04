namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the MultiLevelStringCache Class.
/// </summary>
public class MultiLevelStringCache
{
  /// <summary>
  ///   PointCount.
  /// </summary>
  public UInt32? PointCount { get; set; }

  public Collection<Level>? Levels { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}