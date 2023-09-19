namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a pattern fill. A repeated pattern is used to fill the object.
/// </summary>
public partial class PatternFill
{
  
  /// <summary>
  ///   Specifies one of a set of preset patterns to fill the object.
  /// </summary>
  [SchemaAttr("prst")]
  public DocumentModel.Drawings.PresetPatternValues? Preset { get; set; }
  
  
  /// <summary>
  ///   Foreground color.
  /// </summary>
  public DocumentModel.Drawings.ForegroundColor? ForegroundColor { get; set; }
  
  
  /// <summary>
  ///   Background color.
  /// </summary>
  public DocumentModel.Drawings.BackgroundColor? BackgroundColor { get; set; }
  
}
