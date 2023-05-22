using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TextOutlineEffect Class.
/// </summary>
public class TextOutlineEffect: TypedModelElement, IDrawingProperty
{
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LineWidth { get; set; }

  /// <summary>
  ///   cap, this property is only available in Office 2010 and later.
  /// </summary>
  public LineCapKind? CapType { get; set; }

  /// <summary>
  ///   cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public CompoundLineKind? Compound { get; set; }

  /// <summary>
  ///   algn, this property is only available in Office 2010 and later.
  /// </summary>
  public PenAlignmentKind? Alignment { get; set; }

  public bool? NoFillEmpty { get; set; }

  public SolidColorFillProperties? SolidColorFillProperties { get; set; }

  public GradientFillProperties? GradientFillProperties { get; set; }

  public PresetLineDashKind? PresetLineDashProperties { get; set; }

  public bool? RoundEmpty { get; set; }

  public bool? BevelEmpty { get; set; }

  public LineJoinMiterProperties? LineJoinMiterProperties { get; set; }
}