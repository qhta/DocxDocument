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
  public HexInt? NumberID { get; set; }

  /// <summary>
  ///   durableId
  /// </summary>
  public HexInt? DurableId { get; set; }

  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  public HexInt? AbstractNumId { get; set; }

  public Collection<NumLevelOverride>? LevelOverrides { get; set; }
}