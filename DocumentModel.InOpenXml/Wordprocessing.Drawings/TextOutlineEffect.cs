using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the outline effect applied to text in a Wordprocessing document.
/// This class provides properties for configuring line width, cap type, compound line style, alignment, fill, dash style, and join properties, enabling advanced visual effects for text outlines.
/// </summary>
[DataContract]
[XmlRoot("TextOutlineEffect", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class TextOutlineEffect : IDrawingProperty
{
  /// <summary>
  /// The width of the outline line, specified in units relevant to the document.
  /// </summary>
  public Int32? LineWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// The cap type applied to the ends of the outline line, such as flat, round, or square.
  /// </summary>
  public LineCap? CapType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// The compound line style, specifying whether the outline is single, double, or another compound type.
  /// </summary>
  public CompoundLine? Compound { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// The alignment of the outline pen, specifying how the outline is positioned relative to the text edge.
  /// </summary>
  public PenAlignment? Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that no fill is applied to the outline.
  /// </summary>
  public bool? NoFillEmpty { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// The solid color fill properties for the outline, specifying a single color fill.
  /// </summary>
  public SolidColorFillProperties? SolidColorFillProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// The gradient fill properties for the outline, specifying a color gradient fill.
  /// </summary>
  public GradientFillProperties? GradientFillProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// The preset line dash style for the outline, such as solid, dash, or dot.
  /// </summary>
  public PresetLineDash? PresetLineDashProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that the outline uses a round join style.
  /// </summary>
  public bool? RoundEmpty { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that the outline uses a bevel join style.
  /// </summary>
  public bool? BevelEmpty { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// The miter join properties for the outline, specifying the miter limit and related settings.
  /// </summary>
  public LineJoinMiterProperties? LineJoinMiterProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}