namespace DocumentModel.Drawings.Wordprocessing;
/// <summary>
///   Additional extent for object effects.
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