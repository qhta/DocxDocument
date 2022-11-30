namespace DocumentModel.Office2010.Word;

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
  public DocumentModel.Office2010.Word.LineCapKind? CapType { get ; set; }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.CompoundLineKind? Compound { get ; set; }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.PenAlignmentKind? Alignment { get ; set; }
  
  public System.Boolean? NoFillEmpty { get ; set; }
  
  public DocumentModel.Office2010.Word.ISolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  public DocumentModel.Office2010.Word.IGradientFillProperties? GradientFillProperties { get ; set; }
  
  public DocumentModel.Office2010.Word.PresetLineDashKind? PresetLineDashProperties { get ; set; }
  
  public System.Boolean? RoundEmpty { get ; set; }
  
  public System.Boolean? BevelEmpty { get ; set; }
  
  public DocumentModel.Office2010.Word.ILineJoinMiterProperties? LineJoinMiterProperties { get ; set; }
  
}
