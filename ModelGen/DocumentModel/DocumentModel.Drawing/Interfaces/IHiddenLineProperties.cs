namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public interface IHiddenLineProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// line width
  /// </summary>
  public Int32? Width { get ; set; }
  
  /// <summary>
  /// line cap
  /// </summary>
  public LineCapKind? CapType { get ; set; }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public CompoundLineKind? CompoundLineType { get ; set; }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public PenAlignmentKind? Alignment { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public ISolidFill? SolidFill { get ; set; }
  
  public IGradientFill? GradientFill { get ; set; }
  
  public IPatternFill? PatternFill { get ; set; }
  
  public PresetLineDashKind? PresetDash { get ; set; }
  
  public ICustomDash? CustomDash { get ; set; }
  
  public Boolean? Round { get ; set; }
  
  public Boolean? LineJoinBevel { get ; set; }
  
  public IMiter? Miter { get ; set; }
  
  public ILineEndPropertiesType? HeadEnd { get ; set; }
  
  public ILineEndPropertiesType? TailEnd { get ; set; }
  
  public ILinePropertiesExtensionList? LinePropertiesExtensionList { get ; set; }
  
}
