namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HiddenLineProperties Class.
/// </summary>
public partial class HiddenLineProperties
{
  
  /// <summary>
  ///   line width
  /// </summary>
  [SchemaAttr("w")]
  public Int32? Width { get; set; }
  
  
  /// <summary>
  ///   line cap
  /// </summary>
  [SchemaAttr("cap")]
  public DocumentModel.Drawings.LineCapValues? CapType { get; set; }
  
  
  /// <summary>
  ///   compound line type
  /// </summary>
  [SchemaAttr("cmpd")]
  public DocumentModel.Drawings.CompoundLineValues? CompoundLineType { get; set; }
  
  
  /// <summary>
  ///   pen alignment
  /// </summary>
  [SchemaAttr("algn")]
  public DocumentModel.Drawings.PenAlignmentValues? Alignment { get; set; }
  
  public Boolean? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.PresetLineDashValues? PresetDash { get; set; }
  
  public DocumentModel.Drawings.CustomDash? CustomDash { get; set; }
  
  public Boolean? Round { get; set; }
  
  public Boolean? LineJoinBevel { get; set; }
  
  public DocumentModel.Drawings.Miter? Miter { get; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? HeadEnd { get; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? TailEnd { get; set; }
  
  public DocumentModel.Drawings.LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
  
}
