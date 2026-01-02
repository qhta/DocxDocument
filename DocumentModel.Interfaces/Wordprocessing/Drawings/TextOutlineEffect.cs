using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextOutlineEffect Class.
/// </summary>
public class TextOutlineEffect: ITypedModelElement, IDrawingProperty
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
  /// <summary>
  /// 
  /// </summary>
  public bool? NoFillEmpty { get; set; }
  /// <summary>
  /// 
  /// </summary>
  public SolidColorFillProperties? SolidColorFillProperties { get; set; }
  /// <summary>
  /// 
  /// </summary>
  public GradientFillProperties? GradientFillProperties { get; set; }
  /// <summary>
  /// 
  /// </summary>
  public PresetLineDashKind? PresetLineDashProperties { get; set; }
  /// <summary>
  /// 
  /// </summary>
  public bool? RoundEmpty { get; set; }
  /// <summary>
  /// 
  /// </summary>
  public bool? BevelEmpty { get; set; }
  /// <summary>
  /// 
  /// </summary>
  public LineJoinMiterProperties? LineJoinMiterProperties { get; set; }
}