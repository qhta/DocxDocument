namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Top and Bottom Wrapping.
/// </summary>
public class WrapTopBottom: ModelElement
{
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop { get; set; }

  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom { get; set; }

  /// <summary>
  ///   Wrapping Boundaries.
  /// </summary>
  public EffectExtent? EffectExtent { get; set; }
}