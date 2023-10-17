namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HiddenLineProperties Class.
/// </summary>
public partial class HiddenLineProperties
{
  
  /// <summary>
  ///   line width
  /// </summary>
  public Int32? Width { get; set; }
  
  
  /// <summary>
  ///   line cap
  /// </summary>
  public DocumentModel.Drawings.LineCapKind? CapType { get; set; }
  
  
  /// <summary>
  ///   compound line type
  /// </summary>
  public DocumentModel.Drawings.CompoundLineKind? CompoundLineType { get; set; }
  
  
  /// <summary>
  ///   pen alignment
  /// </summary>
  public DocumentModel.Drawings.PenAlignmentKind? Alignment { get; set; }
  
  public DocumentModel.Drawings.NoFill? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.PresetLineDashKind? PresetDash { get; set; }
  
  public DocumentModel.Drawings.CustomDash? CustomDash { get; set; }
  
  public DocumentModel.Drawings.Round? Round { get; set; }
  
  public DocumentModel.Drawings.LineJoinBevel? LineJoinBevel { get; set; }
  
  public DocumentModel.Drawings.Miter? Miter { get; set; }
  
  public DocumentModel.Drawings.HeadEnd? HeadEnd { get; set; }
  
  public DocumentModel.Drawings.TailEnd? TailEnd { get; set; }
  
  public DocumentModel.Drawings.LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
  
}
