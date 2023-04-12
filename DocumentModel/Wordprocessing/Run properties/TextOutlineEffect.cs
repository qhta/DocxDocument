namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextOutlineEffect Class.
/// </summary>
public class TextOutlineEffect: ModelElement
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

  public Boolean? NoFillEmpty { get; set; }

  public SolidColorFillProperties? SolidColorFillProperties { get; set; }

  public GradientFillProperties? GradientFillProperties { get; set; }

  public PresetLineDashKind? PresetLineDashProperties { get; set; }

  public Boolean? RoundEmpty { get; set; }

  public Boolean? BevelEmpty { get; set; }

  public LineJoinMiterProperties? LineJoinMiterProperties { get; set; }
}