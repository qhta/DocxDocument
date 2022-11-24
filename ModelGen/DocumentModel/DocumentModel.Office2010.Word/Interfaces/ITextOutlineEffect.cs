namespace DocumentModel.Office2010.Word;

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
  public LineCapValues? CapType { get ; set; }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public CompoundLineValues? Compound { get ; set; }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public PenAlignmentValues? Alignment { get ; set; }
  
}
