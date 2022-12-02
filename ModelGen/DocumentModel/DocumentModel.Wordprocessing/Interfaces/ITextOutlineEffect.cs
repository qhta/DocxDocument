namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public interface ITextOutlineEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LineWidth { get ; set; }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public LineCapKind? CapType { get ; set; }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public CompoundLineKind? Compound { get ; set; }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public PenAlignmentKind? Alignment { get ; set; }
  
  public Boolean? NoFillEmpty { get ; set; }
  
  public ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  public IGradientFillProperties? GradientFillProperties { get ; set; }
  
  public PresetLineDashKind? PresetLineDashProperties { get ; set; }
  
  public Boolean? RoundEmpty { get ; set; }
  
  public Boolean? BevelEmpty { get ; set; }
  
  public ILineJoinMiterProperties? LineJoinMiterProperties { get ; set; }
  
}
