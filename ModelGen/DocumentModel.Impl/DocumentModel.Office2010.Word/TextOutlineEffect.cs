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
public class TextOutlineEffect: ITextOutlineEffect
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public int? LineWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.LineCapValues? CapType
  {
    get;
    set;
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.CompoundLineValues? Compound
  {
    get;
    set;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.PenAlignmentValues? Alignment
  {
    get;
    set;
  }
  
}
