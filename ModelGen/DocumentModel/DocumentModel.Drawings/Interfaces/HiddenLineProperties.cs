namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public partial interface HiddenLineProperties
{
  /// <summary>
  /// line width
  /// </summary>
  public Int32? Width { get; set; }
  
  /// <summary>
  /// line cap
  /// </summary>
  public DocumentModel.Drawings.LineCapKind? CapType { get; set; }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public DocumentModel.Drawings.CompoundLineKind? CompoundLineType { get; set; }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public DocumentModel.Drawings.PenAlignmentKind? Alignment { get; set; }
  
  public Boolean? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.PresetLineDashKind? PresetDash { get; set; }
  
  public DocumentModel.Drawings.CustomDash? CustomDash { get; set; }
  
  public Boolean? Round { get; set; }
  
  public Boolean? LineJoinBevel { get; set; }
  
  public DocumentModel.Drawings.Miter? Miter { get; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? HeadEnd { get; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? TailEnd { get; set; }
  
  public DocumentModel.Drawings.LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
  
}
