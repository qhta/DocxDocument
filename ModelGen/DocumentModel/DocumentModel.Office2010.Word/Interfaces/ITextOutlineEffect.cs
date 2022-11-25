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
  
}
