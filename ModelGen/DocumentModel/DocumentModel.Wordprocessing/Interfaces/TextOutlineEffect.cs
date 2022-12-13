namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public interface TextOutlineEffect
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LineWidth { get ; set; }
  
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
  
  public Boolean? NoFillEmpty { get ; set; }
  
  public DocumentModel.Wordprocessing.SolidColorFillProperties? SolidColorFillProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.GradientFillProperties? GradientFillProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.PresetLineDashKind? PresetLineDashProperties { get ; set; }
  
  public Boolean? RoundEmpty { get ; set; }
  
  public Boolean? BevelEmpty { get ; set; }
  
  public DocumentModel.Wordprocessing.LineJoinMiterProperties? LineJoinMiterProperties { get ; set; }
  
}
