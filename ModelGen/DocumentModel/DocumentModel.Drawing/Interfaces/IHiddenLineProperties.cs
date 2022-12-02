namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public interface IHiddenLineProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// line width
  /// </summary>
  public System.Int32? Width { get ; set; }
  
  /// <summary>
  /// line cap
  /// </summary>
  public DocumentModel.Drawing.LineCapKind? CapType { get ; set; }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public DocumentModel.Drawing.CompoundLineKind? CompoundLineType { get ; set; }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public DocumentModel.Drawing.PenAlignmentKind? Alignment { get ; set; }
  
  public System.Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawing.ISolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  public DocumentModel.Drawing.PresetLineDashKind? PresetDash { get ; set; }
  
  public DocumentModel.Drawing.ICustomDash? CustomDash { get ; set; }
  
  public System.Boolean? Round { get ; set; }
  
  public System.Boolean? LineJoinBevel { get ; set; }
  
  public DocumentModel.Drawing.IMiter? Miter { get ; set; }
  
  public DocumentModel.Drawing.ILineEndPropertiesType? HeadEnd { get ; set; }
  
  public DocumentModel.Drawing.ILineEndPropertiesType? TailEnd { get ; set; }
  
  public DocumentModel.Drawing.ILinePropertiesExtensionList? LinePropertiesExtensionList { get ; set; }
  
}
