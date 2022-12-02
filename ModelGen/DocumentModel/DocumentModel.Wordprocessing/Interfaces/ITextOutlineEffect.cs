namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public interface ITextOutlineEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? LineWidth { get ; set; }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.LineCapKind? CapType { get ; set; }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.CompoundLineKind? Compound { get ; set; }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PenAlignmentKind? Alignment { get ; set; }
  
  public System.Boolean? NoFillEmpty { get ; set; }
  
  public DocumentModel.Wordprocessing.ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IGradientFillProperties? GradientFillProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.PresetLineDashKind? PresetLineDashProperties { get ; set; }
  
  public System.Boolean? RoundEmpty { get ; set; }
  
  public System.Boolean? BevelEmpty { get ; set; }
  
  public DocumentModel.Wordprocessing.ILineJoinMiterProperties? LineJoinMiterProperties { get ; set; }
  
}
