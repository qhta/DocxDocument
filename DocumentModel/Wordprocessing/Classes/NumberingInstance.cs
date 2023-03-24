namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Numbering Definition Instance.
/// </summary>
public class NumberingInstance: ModelElement
{
  /// <summary>
  ///   numId
  /// </summary>
  public Int32? NumberID { get; set; }

  /// <summary>
  ///   durableId
  /// </summary>
  public Int32? DurableId { get; set; }

  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  public Int32? AbstractNumId { get; set; }

  public Collection<LevelOverride>? LevelOverrides { get; set; }
}