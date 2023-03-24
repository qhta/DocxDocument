namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MultiLevelStringCache Class.
/// </summary>
public class MultiLevelStringCache: ModelElement
{
  /// <summary>
  ///   PointCount.
  /// </summary>
  public UInt32? PointCount { get; set; }

  public Collection<Level>? Levels { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}