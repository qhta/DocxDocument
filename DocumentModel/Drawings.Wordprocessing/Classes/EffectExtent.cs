namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Object Extents Including Effects.
/// </summary>
[TypeConverter(typeof(EffectExtentTypeConverter))]
public class EffectExtent: ModelElement
{
  /// <summary>
  ///   Additional Extent on Left Edge
  /// </summary>
  public EMU LeftEdge { get; set; }

  /// <summary>
  ///   Additional Extent on Top Edge
  /// </summary>
  public EMU TopEdge { get; set; }

  /// <summary>
  ///   Additional Extent on Right Edge
  /// </summary>
  public EMU RightEdge { get; set; }

  /// <summary>
  ///   Additional Extent on Bottom Edge
  /// </summary>
  public EMU BottomEdge { get; set; }
}