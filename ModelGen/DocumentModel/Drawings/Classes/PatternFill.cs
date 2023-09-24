namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a pattern fill. A repeated pattern is used to fill the object.
/// </summary>
public partial class PatternFill
{
  
  /// <summary>
  ///   Specifies one of a set of preset patterns to fill the object.
  /// </summary>
  public PresetPatternKind? Preset { get; set; }
  
  
  /// <summary>
  ///   Foreground color.
  /// </summary>
  public ForegroundColor? ForegroundColor { get; set; }
  
  
  /// <summary>
  ///   Background color.
  /// </summary>
  public BackgroundColor? BackgroundColor { get; set; }
  
}
