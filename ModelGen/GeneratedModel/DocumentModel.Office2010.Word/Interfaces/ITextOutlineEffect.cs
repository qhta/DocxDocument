namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INoFillEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRoundEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IBevelEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IGradientFillProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILineJoinMiterProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IPresetLineDashProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISolidColorFillProperties))]
public interface ITextOutlineEffect // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public int? LineWidth { get ; set; }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.LineCap? CapType { get ; set; }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.CompoundLine? Compound { get ; set; }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.PenAlignment? Alignment { get ; set; }
  
}
