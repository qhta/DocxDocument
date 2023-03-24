namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Object Extents Including Effects.
/// </summary>
public class EffectExtent: ModelElement
{
  /// <summary>
  ///   Additional Extent on Left Edge
  /// </summary>
  public Int64? LeftEdge { get; set; }

  /// <summary>
  ///   Additional Extent on Top Edge
  /// </summary>
  public Int64? TopEdge { get; set; }

  /// <summary>
  ///   Additional Extent on Right Edge
  /// </summary>
  public Int64? RightEdge { get; set; }

  /// <summary>
  ///   Additional Extent on Bottom Edge
  /// </summary>
  public Int64? BottomEdge { get; set; }
}